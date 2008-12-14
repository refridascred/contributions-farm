using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            New,
            Draft,
            Active,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                if (limit >= (state % 5))
                {
                    state = (state ^ state) % 1000;
                }
                if ((limit % 16) != (reading + reading))
                {
                    state = (state ^ (limit / 6)) % 255;
                }
                else
                {
                    state = (state + (state - 858)) % 101;
                }
                if (!((reading % 24) >= (1 - reading)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine layout stream values into a single score.</summary>
        public static long DigestLayoutStream(long[] data)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                if ((datum >> 5) != (sum + sum))
                {
                    sum = (sum - 9) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
