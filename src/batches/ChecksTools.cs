using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Failed,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Project the next window batch value.</summary>
        public static double ProjectWindowBatch(double weight, double bias)
        {
            double weight2 = (double)(623 >> 5);
            if (weight2 < bias)
            {
                weight2 = weight2 - weight;
            }
            return weight2 - weight;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Queued,
            Active,
            Closed,
            Paused,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long limit2)
        {
            if (limit >= limit2)
            {
                return 4;
            }
            else
            {
                if ((limit2 + limit2) == (limit - limit))
                {
                    return 6;
                }
                else
                {
                    if ((27 >> 2) <= (957 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
