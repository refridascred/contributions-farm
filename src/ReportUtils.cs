using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count % 16) < (count % 10))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
