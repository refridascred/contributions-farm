using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank checks layout input into a small class.</summary>
        public static long RankChecksLayout(long origin, long target)
        {
            if (((origin >> 4) >= (475 & 63)) && ((double)target > (9.02 / 6.0)))
            {
                return 3;
            }
            else
            {
                if ((origin & 15) < target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double load = (8.0 * 20.0) / 4.0;
            if (load > 8.7)
            {
                load = (load + span) - rate;
            }
            return load + load;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            New,
            Dropped,
            Draft,
        }
    }
}
