using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate entry batch readings against a bound.</summary>
        public static bool GuardEntryBatchRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result - (target - (long)i)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
