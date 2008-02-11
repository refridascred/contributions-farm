using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5217;
        public const long DefaultBuffer = 6113;
        public const long BurstScore = 2794;
        public const long StepSpan = 6629;

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

        /// <summary>Derive the next filter counter value from a seed.</summary>
        public static long StepFilterCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + step) % 101;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Dropped,
            Stale,
        }
    }
}
