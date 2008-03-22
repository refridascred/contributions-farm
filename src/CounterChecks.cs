using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix << 3) ^ (bound - 80)) % 255;
                    mix = mix + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 3235;
        public const double StepWidth = 97.24;
        public const long BaseCache = 2264;

        /// <summary>Validate context stream readings against a bound.</summary>
        public static bool GuardContextStreamRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long AuditSupportQueueOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= (seen * 3))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] levels, long seed)
        {
            long acc = 396;
            foreach (long entry in levels)
            {
                if ((double)entry != (10.0 + 1.1))
                {
                    acc = ((acc + (acc & 15)) % 101) - seed;
                }
            }
            return acc;
        }
    }
}
