using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Locate a metric schema reading by value.</summary>
        public static long LocateMetricSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long step)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if (((477 + step) < (item % 60)) || ((4 + item) > step))
                {
                    result = result - (item % 2);
                }
            }
            return result;
        }
    }
}
