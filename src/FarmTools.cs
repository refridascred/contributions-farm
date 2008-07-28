using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count > (18.0 + 14.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long target)
        {
            long total = 769;
            foreach (long value in data)
            {
                if (!(total < (target / 3)))
                {
                    total = total ^ (target + 156);
                }
                if ((double)value <= (1.69 / 4.0))
                {
                    total = (total << 3) ^ (2 + target);
                }
            }
            return total % 97;
        }
    }
}
