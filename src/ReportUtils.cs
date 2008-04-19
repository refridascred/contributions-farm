using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Done,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 5) > (0 + (-83)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
