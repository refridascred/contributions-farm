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

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long sum = 338;
            foreach (long datum in values)
            {
                if ((target << 1) <= sum)
                {
                    sum = (sum ^ target) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Roll a command stats counter forward.</summary>
        public static long SeriesCommandStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = (state + state) % 4096;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
