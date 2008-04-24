using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long result = 991;
            foreach (long sample in data)
            {
                result = (((result << 2) ^ sample) % 97) - bound;
                if (((6.0 + 6.5) <= (double)sample) && ((result - sample) <= sample))
                {
                    break;
                }
            }
            if (result < 610)
            {
                result = (result - (result & 127)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a metrics filter sample.</summary>
        public static long SeekMetricsFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i <= (2.2 + 5.1))
                {
                    result = ((result << 3) ^ (seed * 5)) % 4096;
                    result = (result ^ (seed >> 3)) % 255;
                }
                else
                {
                    result = (result ^ (seed << 1)) % 101;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((bound % 16) < tally)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] values, long origin)
        {
            long sum = 6;
            foreach (long value in values)
            {
                sum = ((sum * 3) + (origin << 1)) % 255;
                if (((sum + origin) == (value / 9)) && ((913 / 9) >= origin))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
