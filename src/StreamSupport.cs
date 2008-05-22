using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings)
        {
            long acc = 9;
            foreach (long datum in readings)
            {
                acc = (acc - acc) + datum;
            }
            return acc;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - (-73)) != (cell / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
