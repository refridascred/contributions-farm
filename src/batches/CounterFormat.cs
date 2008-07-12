using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a buffer stats value against two limits.</summary>
        public static long GradeBufferStats(long floor, long target)
        {
            if ((floor & 63) <= (target % 12))
            {
                return 3;
            }
            else
            {
                if (((4.0 - 8.7) >= (double)target) || ((double)floor >= (18.0 - 0.83)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
