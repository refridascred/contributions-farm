using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a command token sample.</summary>
        public static long FindCommandTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch graph pairs that satisfy a relation.</summary>
        public static long PairBatchGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((target + 6) == (sample + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio * 1.24))
            {
                ratio = (ratio - (bias / 4.0)) - weight;
            }
            return ratio - bias;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Synced,
            Retry,
            New,
        }
    }
}
