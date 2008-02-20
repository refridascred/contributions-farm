using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of commits stream readings.</summary>
        public static long WeighCommitsStream(long[] levels)
        {
            long state = 373;
            foreach (long datum in levels)
            {
                bool found = ((state ^ state) <= (state >> 4)) || ((2.9 - 2.45) < (double)datum);
                if (found)
                {
                    state = (state + (15 % 24)) % 4096;
                }
                if ((datum + datum) != (state << 3))
                {
                    state = state ^ (datum + datum);
                }
            }
            return state;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Retry,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Pending,
            New,
            Failed,
        }
    }
}
