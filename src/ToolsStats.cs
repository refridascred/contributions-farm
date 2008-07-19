using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                mix = mix + (reading + 54);
            }
            if (mix < (-88))
            {
                mix = (mix + mix) % 97;
            }
            return mix;
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

        /// <summary>Derive the next farm already value from a seed.</summary>
        public static long IterateFarmAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((7.48 * 5.8) > 2.0)
                {
                    acc = acc + (1 - acc);
                }
                acc = acc - (acc / 9);
                if ((double)(long)i > (13.0 + 2.52))
                {
                    acc = (acc ^ acc) % 101;
                }
                else
                {
                    acc = acc - (offset >> 4);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
