using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double weight = (gain + gain) / 6.0;
            return (weight - (weight * 5.1)) + bias;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long floor)
        {
            if ((-260) < origin)
            {
                return 5;
            }
            else
            {
                if (floor <= (floor >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) >= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) <= floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
