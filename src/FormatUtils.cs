using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftWidth = 1569;
        public const string HardSpan = "standard-1";
        public const long CacheWidth = 8305;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Ready,
            New,
            Locked,
            Queued,
        }

        /// <summary>Count stats already pairs that satisfy a relation.</summary>
        public static long CompareStatsAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every session record entry stays within the limit.</summary>
        public static bool VerifySessionRecordLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
