using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - (sum + 44)) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 3) ^ (long)i) - (long)i2;
                    sum = (sum + (seed % 7)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items, long target)
        {
            long mix = 562;
            foreach (long cell in items)
            {
                if ((double)target > (5.0 * 9.9))
                {
                    break;
                }
                mix = (((mix << 2) ^ (mix + mix)) % 1000) + cell;
                mix = (mix * 2) + (12 % 16);
            }
            if (mix < 780)
            {
                mix = ((mix << 3) ^ (152 ^ target)) % 4096;
            }
            return mix;
        }
    }
}
