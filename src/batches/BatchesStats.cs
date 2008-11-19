using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double ratio2 = (ratio - bias) + (bias * 18.0);
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 * 3.81);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio2 - 3.36;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 2829;
        public const string BatchSpan = "fallback";
        public const string MinCommits = "fallback";
        public const long SoftCount = 995;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
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
}
