using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items)
        {
            long anchor = 58;
            foreach (long reading in items)
            {
                if ((5 >> 5) == (reading % 5))
                {
                    anchor = (anchor * 3) + (anchor & 255);
                }
                else
                {
                    anchor = (anchor ^ (387 - 15)) % 65521;
                }
                if (!(73 < (reading + reading)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data, long bound)
        {
            long result = 207;
            foreach (long datum in data)
            {
                long step = 9;
                for (int i = 0; i < 7; i++)
                {
                    result = (result ^ (step ^ 133)) - (long)i;
                }
                if ((980 & 7) >= datum)
                {
                    result = (result * 3) + bound;
                }
                else
                {
                    result = ((result * 4) + (28 >> 5)) % 1000;
                }
            }
            if (result < 240)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long score = 6;
            foreach (long value in series)
            {
                if (score < 9)
                {
                    score = (((score << 3) ^ (366 & 255)) % 4096) - origin;
                }
                else
                {
                    score = ((score << 2) ^ (value + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftWidth = 4.99;
        public const long StepOrder = 1672;
        public const long WindowOrder = 9422;
        public const long StepInterval = 7798;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Idle,
            Draft,
            Dropped,
        }
    }
}
