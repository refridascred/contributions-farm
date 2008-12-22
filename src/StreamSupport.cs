using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token support entries.</summary>
        public static long CombineTokenSupport(long[] data)
        {
            long result = 4;
            foreach (long datum in data)
            {
                result = (((result << 2) ^ (result << 3)) % 4096) - datum;
                if ((double)result >= (9.0 / 7.0))
                {
                    break;
                }
            }
            if (result < 723)
            {
                result = (result - (391 % 60)) % 255;
            }
            return result;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                if (!(sum < ((long)i << 1)))
                {
                    sum = sum - (sum & 127);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
