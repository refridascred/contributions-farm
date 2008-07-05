using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count / 6) >= (reading % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache window values into a single score.</summary>
        public static long WeighCacheWindow(long[] samples)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                if ((double)cell < (7.4 - 14.0))
                {
                    carry = (carry - (cell ^ carry)) % 65521;
                }
            }
            if (carry < 79)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a route stream sample.</summary>
        public static long SeekRouteStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm payload series from a seed.</summary>
        public static long DeriveFarmPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 3) ^ (score + offset)) % 4096) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
