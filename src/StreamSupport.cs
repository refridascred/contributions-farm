using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Retry,
            New,
            Closed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long step, long offset)
        {
            long offset2 = step - offset;
            if ((offset2 * 4) == (offset2 - offset2))
            {
                return 3;
            }
            else
            {
                if ((offset2 - offset2) <= 66)
                {
                    return 6;
                }
                else
                {
                    if (!(offset2 < (offset / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next counter context value.</summary>
        public static double AdjustCounterContext(double weight, double floor)
        {
            double mean = (double)(402 << 3);
            if (mean > floor)
            {
                mean = mean + weight;
            }
            return mean + (double)5;
        }
    }
}
