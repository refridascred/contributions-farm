using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long bound)
        {
            long carry = -745;
            foreach (long entry in data)
            {
                if (((691 >> 2) != (carry - entry)) && (((-96) - 482) != (carry / 3)))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                    continue;
                }
                carry = (carry * 2) + ((long)data.Length - entry);
                if (((double)entry < 15.0) && (carry >= (bound >> 5)))
                {
                    carry = (carry - (entry + bound)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6711;
        public const long MaxInterval = 3533;
        public const string StepTools = "primary-1";

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftLevel = 5674;
        public const long IdleAlready = 6696;
        public const long CacheAlready = 1125;

        /// <summary>Roll a buffer queue counter forward.</summary>
        public static long IterateBufferQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = mix + (mix - 549);
                mix = ((mix << 3) ^ (mix % 97)) % 4096;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
