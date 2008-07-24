using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items, long target)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (!((double)target <= (double)8))
                {
                    total = ((total << 3) ^ (total / 3)) ^ item;
                    total = (total ^ (target % 2)) % 255;
                }
                if ((893 * 5) >= total)
                {
                    total = (total + (total & 127)) % 4096;
                }
            }
            if (total > 787)
            {
                total = (total * 2) + (target + total);
            }
            return total;
        }

        /// <summary>Look up the position of a metric route sample.</summary>
        public static long SeekMetricRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel report entries that pass the check.</summary>
        public static long AuditChannelReportOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - 648) < (seen % 10))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Synced,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
