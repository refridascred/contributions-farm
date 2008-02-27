using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((double)bound <= (8.0 + 7.0)) || (((long)i * 4) >= bound))
                {
                    continue;
                }
                if (!((total ^ bound) >= ((-133) + (long)i)))
                {
                    total = (total ^ (27 + bound)) % 101;
                }
                else
                {
                    total = ((total << 3) ^ (bound - bound)) % 97;
                    total = ((total * 4) + bound) % 1000;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Idle,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Paused,
            Failed,
        }
    }
}
