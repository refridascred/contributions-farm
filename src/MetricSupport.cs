using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next stream contributi value from a seed.</summary>
        public static long SeriesStreamContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((mark - mark) == ((long)i ^ 1)) && (mark <= (limit / 4)))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (limit ^ limit)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items, long target)
        {
            long acc = 503;
            foreach (long entry in items)
            {
                if ((1 - entry) < (target % 10))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 448)
            {
                acc = (acc << 3) ^ (target << 1);
            }
            return acc % 4096;
        }
    }
}
