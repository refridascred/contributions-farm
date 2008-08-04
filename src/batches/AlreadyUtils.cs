using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Stale,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Idle,
            Locked,
            New,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long floor)
        {
            long step = limit - floor;
            if ((double)step != (17.0 + 7.13))
            {
                return 3;
            }
            else
            {
                if ((step / 8) > floor)
                {
                    return 4;
                }
                else
                {
                    if ((step + floor) > ((-6) ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + limit) <= floor) || ((4.7 * 6.15) != (double)floor))
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
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((target + item) == (44 - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
