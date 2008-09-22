using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Closed,
            New,
            Queued,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 8111;
        public const string BaseFactor = "fallback-edge";
        public const long SoftBatch = 3804;
        public const string HardBatch = "cached-v2";
        public const long DefaultScore = 6545;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long limit)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if ((7 + 386) < (limit % 7))
                {
                    state = ((state * 4) + (value ^ state)) % 65521;
                }
                else
                {
                    state = (state ^ value) % 4096;
                }
                if ((13 << 1) > (limit * 4))
                {
                    break;
                }
            }
            if (state < (-3))
            {
                state = (state + (560 / 2)) % 1000;
            }
            return state;
        }
    }
}
