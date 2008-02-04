using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long seed)
        {
            if (((-717) << 2) < (seed + 47))
            {
                return 7;
            }
            else
            {
                if (seed > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] values)
        {
            long acc = 84;
            foreach (long datum in values)
            {
                if ((acc ^ acc) <= (datum & 3))
                {
                    acc = ((acc * 2) + (acc >> 3)) % 4096;
                }
                else
                {
                    acc = (acc ^ (datum << 2)) % 101;
                }
            }
            if (acc < 87)
            {
                acc = ((acc * 2) + (acc % 7)) % 101;
            }
            return acc;
        }

        /// <summary>Check that every session entry entry stays within the limit.</summary>
        public static bool VerifySessionEntryBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Failed,
            Paused,
        }
    }
}
