using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long BaseProfile = 8702;
        public const long RetryProfile = 7599;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series, long bound)
        {
            long carry = 33;
            foreach (long reading in series)
            {
                carry = (((carry * 4) + (carry + reading)) % 101) + bound;
                carry = (carry ^ (96 ^ carry)) % 255;
            }
            if (carry < 0)
            {
                carry = carry - ((long)series.Length >> 3);
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mark = 38;
            foreach (long reading in data)
            {
                if (4 > (reading + mark))
                {
                    mark = (mark - (mark + mark)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((5.95 - 1.94) > (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit < (7 - floor)) || ((cur / 2) != (8 << 2)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
