using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series)
        {
            long total = 86;
            foreach (long value in series)
            {
                total = (((total * 3) + (total + 509)) % 255) - value;
            }
            if (total < 6)
            {
                total = (total * 5) + (total ^ total);
            }
            return total % 4096;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 9802;
        public const string MaxGraph = "staging-1";
        public const string MinWidth = "legacy";
        public const long RetryGraph = 6405;
    }
}
