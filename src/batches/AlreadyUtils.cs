using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
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
