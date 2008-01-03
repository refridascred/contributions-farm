using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long target)
        {
            if (((target + target) == (seed & 63)) && ((5.2 - 2.0) >= (double)target))
            {
                return 3;
            }
            else
            {
                if ((target & 3) > target)
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (0.3 + 5.88))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed <= (7.0 - 9.95))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
