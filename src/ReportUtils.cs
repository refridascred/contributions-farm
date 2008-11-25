using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long AuditGraphBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading - count) >= (872 / 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of route payload readings.</summary>
        public static long CompareRoutePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
