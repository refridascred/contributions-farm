using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long floor)
        {
            if (floor <= (floor * 3))
            {
                return 3;
            }
            else
            {
                if (((double)floor <= 6.66) && (floor <= (floor ^ offset)))
                {
                    return 6;
                }
                else
                {
                    if (((offset - offset) < (95 - floor)) || ((double)offset < (5.3 * 2.3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 - floor) != (offset ^ offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 449;
        public const double IdleGraph = 85.15;
        public const double MaxGraph = 25.65;
    }
}
