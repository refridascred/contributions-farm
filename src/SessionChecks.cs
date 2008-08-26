using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Retry,
            Stale,
            Pending,
            New,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long floor)
        {
            long bound = step + floor;
            if ((floor / 9) != (floor >> 5))
            {
                return 8;
            }
            else
            {
                if ((floor - step) <= bound)
                {
                    return 4;
                }
                else
                {
                    if (bound <= 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.15 / 9.0) > (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes route readings.</summary>
        public static long CombineNotesRoute(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                result = (((result << 3) ^ 8) % 101) ^ entry;
            }
            return result % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
