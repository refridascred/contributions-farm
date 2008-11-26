using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                if (!((sum + reading) <= 2))
                {
                    sum = (sum - (sum << 1)) % 4096;
                }
                else
                {
                    sum = (sum * 3) + (-1);
                }
                if ((reading / 2) > sum)
                {
                    sum = ((sum << 2) ^ (sum - 64)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ (result % 60);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of format payload entries.</summary>
        public static long TallyFormatPayload(long[] values)
        {
            long result = -342;
            foreach (long entry in values)
            {
                if (result < (entry - result))
                {
                    result = ((result << 3) ^ result) % 255;
                }
                else
                {
                    result = ((result << 3) ^ (entry - 93)) % 65521;
                }
            }
            return result;
        }
    }
}
