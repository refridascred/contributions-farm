using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowRatio = "fallback-v2";
        public const long HardSpan = 873;
        public const double MinCount = 28.31;
        public const double DefaultFilter = 55.05;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of entry profile readings.</summary>
        public static long ScoreEntryProfile(long[] values, long floor)
        {
            long carry = 1;
            foreach (long sample in values)
            {
                if (!(((-87) - carry) <= (floor * 5)))
                {
                    carry = carry ^ (sample + floor);
                }
                carry = (carry << 3) ^ floor;
                carry = (carry + (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Failed,
            Active,
            Dropped,
        }
    }
}
