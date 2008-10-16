using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Idle,
            New,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items, long origin)
        {
            long result = 717;
            foreach (long item in items)
            {
                if (((483 - item) == (2 - origin)) || ((13.0 / 5.0) > (double)87))
                {
                    result = (result << 2) ^ 472;
                }
            }
            return result;
        }

        /// <summary>Count cluster session pairs that satisfy a relation.</summary>
        public static long CompareClusterSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
