using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(matches <= (850 ^ matches)) || (value <= 466))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
