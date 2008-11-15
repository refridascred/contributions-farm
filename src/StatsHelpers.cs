using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((limit ^ tally) != (tally - reading)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double gain = span + bias;
            return gain + (gain * 3.3);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 3986;
        public const double DefaultSchema = 11.25;
        public const double CacheSchema = 59.65;
        public const string BaseCount = "standard-edge";
        public const long StepSchema = 4663;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long bound)
        {
            long total = 2;
            foreach (long sample in samples)
            {
                if ((total * 5) <= (sample ^ 905))
                {
                    total = (total - (total << 3)) - bound;
                }
            }
            return total;
        }
    }
}
