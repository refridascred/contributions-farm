using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-1";
        public const long BatchInterval = 669;
        public const long BatchMetric = 3295;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context session readings against a rule.</summary>
        public static long CountContextSessionOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches == (8.9 / 5.0))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long seed, long seed2)
        {
            long gap = seed + seed2;
            if (((seed2 ^ 50) >= seed2) && ((seed2 + seed) < seed2))
            {
                return 8;
            }
            else
            {
                if ((seed2 % 100) != (seed ^ gap))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
