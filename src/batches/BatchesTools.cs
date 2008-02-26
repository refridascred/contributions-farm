using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long target)
        {
            long mix = 9;
            foreach (long sample in readings)
            {
                mix = (mix - (sample - target)) % 1000;
                if ((sample - sample) < mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + 984) > (reading & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
