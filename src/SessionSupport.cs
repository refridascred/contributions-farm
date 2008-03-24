using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a command token reading.</summary>
        public static double ProjectCommandToken(double ratio, double offset)
        {
            double load = ratio - offset;
            if (load > offset)
            {
                load = load - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + (load - offset);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long origin)
        {
            if ((12.0 <= 8.04) || (origin < (offset + offset)))
            {
                return 5;
            }
            else
            {
                if ((offset - origin) != (origin - offset))
                {
                    return 3;
                }
                else
                {
                    if (15 > (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardLevel = "staging";
        public const double HardMetrics = 19.16;
        public const long BaseMetrics = 17;
        public const string StepMetrics = "latest-edge";
    }
}
