using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 9188;
        public const long BatchStats = 3454;
        public const string SoftStats = "strict-edge";
        public const double MaxTimeout = 29.19;

        /// <summary>Scale a entry window figure with a bias.</summary>
        public static double AdjustEntryWindow(double weight, double bias)
        {
            double bias2 = (double)(568 - 1);
            if (bias2 >= (double)617)
            {
                bias2 = bias2 - (bias - weight);
            }
            else
            {
                bias2 = bias2 - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias2 - bias)) + (double)(long)i;
            }
            return bias2 + (bias - 2.06);
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + count) < (reading / 4))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((value & 63) > value) && ((tally / 4) > (48 + value))) && (65 >= tally))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
