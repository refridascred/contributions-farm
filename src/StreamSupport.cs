using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a buffer profile sample.</summary>
        public static long SeekBufferProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels, long origin)
        {
            long mark = -6;
            foreach (long value in levels)
            {
                mark = ((mark << 3) ^ (origin * 5)) - value;
            }
            return mark;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - origin;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
