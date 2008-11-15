using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings, long floor)
        {
            long total = 414;
            foreach (long value in readings)
            {
                total = (((total * 4) + (0 ^ value)) % 101) - floor;
            }
            return total;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultDepth = 45.54;
        public const double RetryChannel = 32.76;
        public const long MaxSpan = 1864;
        public const long LimitChannel = 8814;
        public const long CacheChannel = 3782;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count <= reading) && (13.0 < (double)count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mark = 264;
            foreach (long cell in levels)
            {
                mark = mark ^ (cell * 4);
                mark = mark ^ (cell % 10);
            }
            if (mark < 103)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
