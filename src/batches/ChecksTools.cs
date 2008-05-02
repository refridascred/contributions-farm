using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < (tally / 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Paused,
            Ready,
        }
    }
}
