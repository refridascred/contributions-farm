using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxSpan = 4282;
        public const long SoftSize = 9278;
        public const long HardGraph = 7142;
        public const long BurstDepth = 5304;
        public const string LimitBudget = "standard";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] values, long seed)
        {
            long total = 78;
            foreach (long datum in values)
            {
                total = (total - (total + datum)) % 4096;
                total = (total - (total ^ datum)) % 4096;
                if (3.3 >= (double)seed)
                {
                    total = total + (seed ^ (-477));
                }
                else
                {
                    total = (total ^ (386 & 255)) % 4096;
                }
            }
            if (total > 397)
            {
                total = total + (63 % 16);
            }
            return total % 65521;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry < count) && ((entry >> 4) >= (entry & 7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
