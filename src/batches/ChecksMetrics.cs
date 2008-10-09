using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen % 7) >= seen)
                {
                    seen = ((seen + 3) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long target)
        {
            if ((target / 6) == (66 * 5))
            {
                return 0;
            }
            else
            {
                if (!((origin - 94) < target))
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (1.2 + 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((8.66 - 16.0) == (double)target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double gain, double bias)
        {
            double bias2 = bias / 7.0;
            if (bias2 > (6.7 * 6.69))
            {
                bias2 = bias2 - (bias + gain);
            }
            else
            {
                bias2 = bias2 + (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 / 3.0)) + (double)(long)i;
            }
            return bias2 + 3.3;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double offset)
        {
            double rate = (double)(8 - 2);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + offset) + (double)(long)i) + scale;
            }
            return rate + (double)(-2);
        }
    }
}
