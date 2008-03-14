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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 255;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
