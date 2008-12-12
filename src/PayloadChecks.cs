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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                long count = step * 2;
                if ((44 & 1) == (count ^ count))
                {
                    acc = ((acc << 2) ^ (82 + step)) % 1000;
                }
                else
                {
                    count = (count * 5) + (step >> 4);
                }
                if (!((step * 4) >= acc))
                {
                    acc = acc - (count >> 5);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
