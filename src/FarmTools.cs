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

        /// <summary>Audit payload farm readings against a rule.</summary>
        public static long AuditPayloadFarmOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((sample >> 5) <= count) || ((seed & 7) <= count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
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
