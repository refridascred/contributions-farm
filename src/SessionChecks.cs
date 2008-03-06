using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long bound)
        {
            if (!((step ^ bound) == (45 << 2)))
            {
                return 2;
            }
            else
            {
                if ((121 % 8) != (step + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings, long floor)
        {
            long carry = 66;
            foreach (long sample in readings)
            {
                if ((double)carry <= (8.0 * 8.5))
                {
                    carry = carry - ((-862) >> 5);
                }
                if ((floor & 15) > sample)
                {
                    break;
                }
            }
            if (carry < 673)
            {
                carry = ((carry * 4) + ((long)readings.Length / 9)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) != (713 >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
