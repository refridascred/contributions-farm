using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)73 < (double)floor)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Pending,
            Failed,
            Closed,
            Draft,
        }
    }
}
