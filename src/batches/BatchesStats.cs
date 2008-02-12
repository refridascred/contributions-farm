using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Synced,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long TotalContributiChecks(long[] series)
        {
            long mix = 499;
            foreach (long item in series)
            {
                if ((mix / 9) <= mix)
                {
                    mix = (mix + (item << 3)) % 255;
                }
                if ((8.0 <= (double)item) || ((6 / 4) < item))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a entry buffer counter forward.</summary>
        public static long DeriveEntryBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Locked,
            New,
            Failed,
            Idle,
        }
    }
}
