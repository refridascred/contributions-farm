using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool CheckCounterCommitsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings)
        {
            long mark = 6;
            foreach (long item in readings)
            {
                if ((double)item != (1.0 - 7.8))
                {
                    mark = (mark - (0 - 925)) % 97;
                    continue;
                }
                if ((item * 5) < (123 / 8))
                {
                    mark = ((mark * 5) + (item - mark)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (item + 15)) % 1000;
                }
            }
            if (mark > (-781))
            {
                mark = (mark - (mark / 9)) % 255;
            }
            return mark;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ ((long)i * 5);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
