using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank metric profile input into a small class.</summary>
        public static long ClassifyMetricProfile(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((bound * 5) > (floor + limit))
            {
                return 6;
            }
            else
            {
                if (floor >= (limit - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound > (floor - floor)) && ((double)floor <= 14.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double weight = 6.08;
            if (weight < weight)
            {
                weight = weight + (offset + bias);
            }
            return weight + (offset - bias);
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Stale,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Match up tools schema samples.</summary>
        public static long CompareToolsSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = ((result - result) + item) + offset;
            }
            return result;
        }
    }
}
