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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
