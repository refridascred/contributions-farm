using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Ready,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double bias = gain;
            if (bias >= offset)
            {
                bias = bias - gain;
            }
            return bias - (double)5;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long seed)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                if ((sum >> 5) < (seed % 97))
                {
                    sum = (((sum << 2) ^ (seed % 64)) % 1000) ^ value;
                }
            }
            return sum;
        }
    }
}
