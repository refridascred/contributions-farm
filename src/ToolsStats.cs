using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a entry githubfarm reading.</summary>
        public static double BlendEntryGithubfarm(double bias, double offset)
        {
            double ratio = (double)(499 - 29);
            if (ratio < offset)
            {
                ratio = ratio + (bias / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Digest a series of cluster githubfarm entries.</summary>
        public static long WeighClusterGithubfarm(long[] values, long target)
        {
            long state = 92;
            foreach (long sample in values)
            {
                if ((sample ^ sample) < (sample % 8))
                {
                    state = (state - (20 + target)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (sample ^ 807)) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen >= (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items, long offset)
        {
            long mix = -3;
            foreach (long item in items)
            {
                mix = ((mix ^ (offset ^ 21)) % 255) ^ item;
            }
            return mix;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
