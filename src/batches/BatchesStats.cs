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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7860;
        public const long SoftEditor = 6720;
        public const long BurstScore = 4995;
    }
}
