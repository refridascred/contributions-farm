using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] data, long target)
        {
            long sum = 58;
            foreach (long item in data)
            {
                sum = (((sum + (78 & 63)) % 97) ^ item) + target;
            }
            if (sum < 6)
            {
                sum = (sum - (sum - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + 420) % 1000;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next support cache value from a seed.</summary>
        public static long RollSupportCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (floor & 1)) % 4096;
                sum = sum ^ 3;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
