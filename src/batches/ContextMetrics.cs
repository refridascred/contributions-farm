using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series)
        {
            long carry = 82;
            foreach (long cell in series)
            {
                carry = (carry + cell) % 101;
                carry = carry ^ (carry ^ carry);
                carry = carry - (carry + cell);
            }
            return carry % 65521;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long target, long seed)
        {
            if ((90 >> 2) <= (33 - target))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) != (target ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) < (496 & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record stats samples.</summary>
        public static long ScoreRecordStats(long[] data)
        {
            long state = 78;
            foreach (long sample in data)
            {
                state = ((state * 3) + (sample / 3)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
