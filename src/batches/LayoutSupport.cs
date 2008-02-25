using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] readings, long limit)
        {
            long carry = 169;
            foreach (long entry in readings)
            {
                carry = ((carry + (970 << 1)) % 4096) + entry;
            }
            if (carry > (-1))
            {
                carry = (carry << 3) ^ (limit + carry);
            }
            return carry;
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
