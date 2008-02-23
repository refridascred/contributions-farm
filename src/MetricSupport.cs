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

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                if ((entry / 3) > (anchor + anchor))
                {
                    anchor = ((anchor * 2) + (entry ^ anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + 34) % 65521;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 2) + (anchor / 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 449;
        public const double IdleGraph = 85.15;
        public const double MaxGraph = 25.65;
    }
}
