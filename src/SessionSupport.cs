using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((720 % 8) < (tally - sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 38) != (reading / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)seed >= (19.0 + 9.5))
                {
                    carry = carry ^ (seed & 3);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
