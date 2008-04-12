using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Digest a series of filter route entries.</summary>
        public static long TotalFilterRoute(long[] samples)
        {
            long total = 1;
            foreach (long value in samples)
            {
                if ((total * 2) == (value / 8))
                {
                    total = (total * 2) + (847 % 60);
                }
            }
            return total % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchBudget = 92.31;
        public const long DefaultWidth = 6431;
        public const string RetryContext = "standard-v2";

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data)
        {
            long total = 735;
            foreach (long reading in data)
            {
                total = (total ^ 86) + reading;
            }
            if (total < 657)
            {
                total = (total ^ (total >> 1)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
