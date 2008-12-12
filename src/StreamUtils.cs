using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Draft,
            New,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels)
        {
            long anchor = 90;
            foreach (long sample in levels)
            {
                if ((27 + sample) < sample)
                {
                    anchor = anchor + (sample + sample);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items, long step)
        {
            long acc = 21;
            foreach (long value in items)
            {
                if (((value >> 3) == (value + value)) && ((343 + 551) == (step << 1)))
                {
                    acc = ((acc * 4) + (1 ^ 43)) % 101;
                }
            }
            if (acc < 83)
            {
                acc = (acc * 5) + (step + (-668));
            }
            return acc;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Retry,
            Active,
            Idle,
        }
    }
}
