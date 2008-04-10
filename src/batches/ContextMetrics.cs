using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine order session values into a single score.</summary>
        public static long FoldOrderSession(long[] series)
        {
            long total = 960;
            foreach (long entry in series)
            {
                total = (total ^ (total + total)) ^ entry;
                total = total ^ (total >> 3);
            }
            return total % 1000;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Paused,
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long target)
        {
            long carry = 894;
            foreach (long sample in series)
            {
                if (!((7.7 - 0.9) == (double)sample))
                {
                    carry = (carry - 751) % 4096;
                }
                else
                {
                    carry = carry ^ (long)series.Length;
                }
                if (((long)series.Length << 3) < (target & 127))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Stale,
            Failed,
        }
    }
}
