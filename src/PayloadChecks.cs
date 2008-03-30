using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 8440;
        public const double StepFactor = 55.18;
        public const string HardFactor = "alpha-1";
        public const string BaseCount = "primary-1";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell >= (906 & 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long CountNotesCacheMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((6.26 / 5.0) > (double)count)
                {
                    count = ((count + 1) ^ cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples)
        {
            long state = 266;
            foreach (long entry in samples)
            {
                state = (state << 2) ^ entry;
                state = state + state;
            }
            return state % 65521;
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long GradeSupportFarm(long target, long seed)
        {
            if ((seed + seed) == (seed + 277))
            {
                return 3;
            }
            else
            {
                if ((target >> 3) != (seed << 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 3) <= (seed * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + seed) <= (target % 12))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Dropped,
            Draft,
        }
    }
}
