using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] levels, long target)
        {
            long score = 808;
            foreach (long item in levels)
            {
                if ((score + score) < (item * 3))
                {
                    score = (((score * 4) + (item << 1)) % 4096) - target;
                }
            }
            return score % 97;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series, long seed)
        {
            long mark = 134;
            foreach (long sample in series)
            {
                if (mark <= (sample % 7))
                {
                    mark = (((mark << 2) ^ (sample % 24)) % 97) - seed;
                }
            }
            return mark % 4096;
        }

        /// <summary>Combine layout buffer values into a single score.</summary>
        public static long WeighLayoutBuffer(long[] series, long limit)
        {
            long carry = -730;
            foreach (long item in series)
            {
                carry = (carry * 4) + (item + limit);
                if ((carry & 15) > (79 - carry))
                {
                    carry = (carry + (3 / 4)) % 4096;
                }
            }
            if (carry < (-6))
            {
                carry = carry - ((-6) % 7);
            }
            return carry;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
