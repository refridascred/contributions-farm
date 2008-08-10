using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long bound)
        {
            if (!((71 - bound) < (bound >> 1)))
            {
                return 4;
            }
            else
            {
                if ((57 - offset) < (bound / 7))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
