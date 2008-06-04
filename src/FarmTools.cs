using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] readings, long step)
        {
            long sum = 81;
            foreach (long value in readings)
            {
                if (step > (sum & 31))
                {
                    sum = ((sum * 2) + value) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long state = 9;
            foreach (long entry in readings)
            {
                if ((double)state >= (1.05 * 5.0))
                {
                    state = ((state * 3) + (291 & 127)) % 255;
                }
                else
                {
                    state = ((state << 2) ^ entry) % 97;
                }
                if ((5.9 * 12.0) == (double)state)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
