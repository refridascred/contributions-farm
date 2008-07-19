using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count >= (sample & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (6.8 / 5.0))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] data)
        {
            long mix = -808;
            foreach (long datum in data)
            {
                mix = (mix ^ (mix % 7)) + datum;
            }
            if (mix < 39)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm filter pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
