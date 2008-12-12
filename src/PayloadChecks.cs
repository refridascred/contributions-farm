using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] series, long target)
        {
            long score = -27;
            foreach (long reading in series)
            {
                score = (score << 3) ^ (score << 3);
                score = score - (94 * 4);
                if ((double)reading <= (double)target)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long target, long seed)
        {
            long slot = target - seed;
            if (!((7.1 - 1.0) == (double)slot))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (4.1 - 1.06))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Draft,
            Done,
        }
    }
}
