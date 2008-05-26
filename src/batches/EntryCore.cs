using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ value) == (floor << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long bound)
        {
            if (25 < bound)
            {
                return 6;
            }
            else
            {
                if (((1.03 / 3.0) <= (7.48 - 2.9)) && ((0 << 1) == (offset ^ offset)))
                {
                    return 7;
                }
                else
                {
                    if (((bound / 4) > (offset << 2)) && ((bound >> 5) <= 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Done,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Synced,
            Active,
            Dropped,
        }
    }
}
