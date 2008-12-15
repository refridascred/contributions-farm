using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings)
        {
            long carry = 609;
            foreach (long cell in readings)
            {
                if (!((cell - 825) < (cell << 2)))
                {
                    carry = ((carry << 2) ^ cell) % 65521;
                }
                if (cell <= ((long)readings.Length - carry))
                {
                    carry = (carry ^ (carry % 97)) % 1000;
                }
                if ((cell ^ carry) > (carry << 1))
                {
                    break;
                }
            }
            if (carry > (-7))
            {
                carry = ((carry * 4) + (carry << 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many profile batch samples are out of range.</summary>
        public static long TallyProfileBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(bound > (cell << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 2) ^ (long)i;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
