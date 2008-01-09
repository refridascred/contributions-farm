using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next farm editor value.</summary>
        public static double ProjectFarmEditor(double ratio, double span)
        {
            double bias = span;
            if (bias >= (double)7)
            {
                bias = bias - span;
            }
            else
            {
                bias = bias + (ratio * 4.0);
            }
            return bias - bias;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long bound)
        {
            if ((96 & 127) < (bound << 3))
            {
                return 5;
            }
            else
            {
                if (2.5 < (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (((bound * 3) >= (origin + bound)) || ((bound / 6) != (bound + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
