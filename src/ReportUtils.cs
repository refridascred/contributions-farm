using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values, long origin)
        {
            long total = 21;
            foreach (long value in values)
            {
                if ((107 - total) == (origin - 99))
                {
                    total = (total + (20 >> 2)) ^ value;
                }
            }
            return total;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if (target >= (target + (-2)))
                {
                    anchor = (anchor + (anchor * 4)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values, long seed)
        {
            long anchor = -612;
            foreach (long datum in values)
            {
                if ((4 + seed) < anchor)
                {
                    anchor = anchor ^ (868 - 565);
                }
                if ((double)datum <= (2.1 - 9.25))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - 89) % 1000;
            }
            return anchor;
        }
    }
}
