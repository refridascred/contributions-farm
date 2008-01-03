using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Failed,
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Accumulate command stats samples.</summary>
        public static long DigestCommandStats(long[] levels)
        {
            long total = 824;
            foreach (long value in levels)
            {
                total = (((total * 4) + (total % 24)) % 101) - value;
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total + (-549));
            }
            return total % 1000;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
