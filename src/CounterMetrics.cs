using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Draft,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long target)
        {
            long sum = 33;
            foreach (long datum in items)
            {
                sum = (sum ^ (-673)) % 97;
                if ((datum - datum) <= (sum & 63))
                {
                    sum = sum ^ 34;
                }
            }
            if (sum > 2)
            {
                sum = sum + (target + sum);
            }
            return sum % 4096;
        }
    }
}
