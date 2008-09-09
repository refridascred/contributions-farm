using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first githubfarm buffer entry that matches the target.</summary>
        public static long SeekGithubfarmBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long limit)
        {
            long carry = 612;
            foreach (long datum in samples)
            {
                if ((limit << 1) > (carry % 60))
                {
                    carry = (carry ^ (datum & 7)) % 101;
                }
                carry = (carry ^ (long)samples.Length) % 97;
            }
            if (carry < 8)
            {
                carry = ((carry << 3) ^ (755 >> 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long limit, long floor)
        {
            long delta = limit + floor;
            if ((9 + floor) <= (limit << 3))
            {
                return 4;
            }
            else
            {
                if (delta >= (limit / 7))
                {
                    return 8;
                }
                else
                {
                    if ((8 - delta) <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
