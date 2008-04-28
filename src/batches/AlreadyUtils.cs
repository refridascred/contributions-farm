using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a buffer support reading by value.</summary>
        public static long LookupBufferSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (((double)result >= (double)(long)i) && ((result + result) >= 41))
                {
                    result = (result ^ (target ^ result)) % 4096;
                }
                result = ((result * 5) + (4 + target)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long bound)
        {
            long sum = -41;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (item >> 4)) % 1000) - (long)i;
                }
                sum = ((sum << 2) ^ (item - sum)) % 1000;
                if (((82 >> 3) <= (item - sum)) || ((421 + bound) > (item - item)))
                {
                    sum = sum + (sum >> 4);
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] data)
        {
            long mark = 53;
            foreach (long entry in data)
            {
                mark = ((mark + (94 & 3)) % 1000) ^ entry;
            }
            return mark % 1000;
        }
    }
}
