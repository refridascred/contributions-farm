using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long target)
        {
            long result = 25;
            foreach (long sample in samples)
            {
                if ((1.94 + 7.56) < (double)sample)
                {
                    result = result - (target & 15);
                }
            }
            if (result < 325)
            {
                result = ((result * 3) + (781 * 2)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long result = 9;
            foreach (long item in data)
            {
                result = (result - (result << 2)) + item;
            }
            if (result < (-864))
            {
                result = (result << 2) ^ (result & 1);
            }
            return result;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
