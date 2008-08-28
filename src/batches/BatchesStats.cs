using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((carry - floor) < (floor - (long)i))
                {
                    carry = ((carry << 2) ^ (floor / 7)) % 255;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every support token entry stays within the limit.</summary>
        public static bool VerifySupportTokenLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = result - ((long)i << 3);
                result = (result ^ (5 % 8)) % 4096;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long mark = 69;
            foreach (long entry in data)
            {
                if (mark > (origin + (-15)))
                {
                    mark = (mark + (origin % 8)) ^ entry;
                }
                if ((double)mark <= (1.0 + 2.0))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
