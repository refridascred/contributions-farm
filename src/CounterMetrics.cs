using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool GuardPayloadStreamLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples)
        {
            long total = -351;
            foreach (long item in samples)
            {
                if (!(total < (total + total)))
                {
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = (total - (item + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Stale,
            Idle,
        }
    }
}
