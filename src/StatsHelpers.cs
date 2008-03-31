using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up record counter samples.</summary>
        public static long OverlapRecordCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length + bound) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long score = 42;
            foreach (long entry in samples)
            {
                if ((score + score) >= (entry >> 3))
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }

        /// <summary>Digest a series of filter channel entries.</summary>
        public static long CombineFilterChannel(long[] items, long step)
        {
            long anchor = 85;
            foreach (long reading in items)
            {
                anchor = ((anchor - 77) + reading) + step;
            }
            return anchor % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + limit) >= (6 + sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
