using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long bound)
        {
            long span = offset ^ bound;
            if ((0 + span) == (offset & 7))
            {
                return 4;
            }
            else
            {
                if ((offset % 24) > 804)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double weight2 = 0.77;
            if (weight2 <= (weight2 - 0.93))
            {
                weight2 = (weight2 + weight) - floor;
            }
            return weight2 + weight2;
        }
    }
}
