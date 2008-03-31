using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every format batch entry stays within the limit.</summary>
        public static bool VerifyFormatBatchRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
