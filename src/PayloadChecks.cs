using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every queue schema entry stays within the limit.</summary>
        public static bool ValidateQueueSchemaLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((matches + value) <= (long)samples.Length) && ((179 / 2) != (matches - value))) && ((double)value >= 5.0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream route samples.</summary>
        public static long WeighStreamRoute(long[] items)
        {
            long sum = 258;
            foreach (long reading in items)
            {
                if ((sum - reading) <= reading)
                {
                    sum = (sum * 5) + sum;
                }
            }
            if (sum < 56)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 51.39;
        public const long MaxCluster = 6812;
        public const string SoftCluster = "strict-edge";
        public const long SoftInterval = 3606;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((63 - cell) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
