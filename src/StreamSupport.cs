using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a entry context value against two limits.</summary>
        public static long SortEntryContext(long limit, long bound)
        {
            if ((9.87 * 8.8) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((double)limit == (4.7 / 7.0))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) == (bound * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double mean = bias;
            if (mean < (weight - 5.8))
            {
                mean = mean - 9.6;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 4.38) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
