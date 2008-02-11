using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepWidth = 2431;
        public const double LimitInterval = 40.99;
        public const long BatchCommits = 6068;
        public const long LimitTimeout = 5948;
        public const double LimitRatio = 45.45;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (5.0 - 4.3))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)limit > (double)729)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double mean = (double)660 + (span / 2.0);
            if (mean < (double)783)
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean + (gain + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean - span)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Dropped,
            Pending,
            Ready,
            Retry,
        }
    }
}
