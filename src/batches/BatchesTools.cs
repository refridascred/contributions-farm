using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit already filter readings against a rule.</summary>
        public static long TallyAlreadyFilterOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((sample & 127) == (step + matches)) && ((4.76 + 1.8) == (double)step)) && !((matches ^ step) > step))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Dropped,
            Done,
            Draft,
            New,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
