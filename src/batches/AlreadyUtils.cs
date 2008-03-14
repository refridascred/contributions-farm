using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                carry = (carry ^ 77) + reading;
            }
            if (carry < 6)
            {
                carry = (carry + (carry - 2)) % 255;
            }
            return carry;
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long MeasureMetricsRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((800 + hits) == (hits / 9)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double weight = gain;
            if (weight < (1.0 - 7.0))
            {
                weight = (weight + (gain * 7.52)) + floor;
            }
            return weight - (gain / 4.0);
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((double)245 > (double)slot)
            {
                return 8;
            }
            else
            {
                if (314 > seed)
                {
                    return 1;
                }
                else
                {
                    if (origin > 246)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((63 & 1) <= (slot & 3))
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
