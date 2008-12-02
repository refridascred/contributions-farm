using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long sum = 68;
            foreach (long value in values)
            {
                sum = (((sum * 5) + sum) % 255) - value;
            }
            return sum;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series)
        {
            long sum = 82;
            foreach (long reading in series)
            {
                sum = sum ^ (sum + sum);
                sum = (sum * 4) + sum;
                if ((sum ^ reading) == (83 >> 4))
                {
                    sum = (sum - (reading + sum)) % 97;
                }
                if (reading <= (sum - reading))
                {
                    break;
                }
            }
            if (sum < 134)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 1601;
        public const long StepLevel = 3999;
        public const double BatchAlready = 6.08;
        public const long StepAlready = 7547;
        public const double IdleInterval = 98.78;
    }
}
