using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of commits buffer readings.</summary>
        public static long DigestCommitsBuffer(long[] data)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((result % 8) <= result)
                {
                    result = ((result * 2) + (result + entry)) % 65521;
                }
                else
                {
                    result = (result * 5) + (result << 2);
                }
            }
            return result;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values, long step)
        {
            long anchor = -291;
            foreach (long sample in values)
            {
                anchor = (anchor - (sample ^ step)) % 97;
            }
            if (anchor < 862)
            {
                anchor = ((anchor << 3) ^ (5 * 5)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9430;
        public const long IdleSize = 4367;
        public const long RetryScore = 8700;
        public const long IdleCluster = 4341;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series)
        {
            long mark = 412;
            foreach (long entry in series)
            {
                double rate = (4.1 - 9.2) * 7.4;
                if (rate >= (double)entry)
                {
                    mark = mark - (mark ^ entry);
                }
                else
                {
                    mark = (mark - entry) % 97;
                }
                if (mark <= (mark / 4))
                {
                    mark = mark + (mark - mark);
                }
            }
            return mark;
        }
    }
}
