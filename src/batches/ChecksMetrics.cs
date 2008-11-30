using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings, long origin)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                if ((sample + origin) >= (score & 255))
                {
                    score = (score << 2) ^ (score - origin);
                }
                if ((origin << 3) <= sample)
                {
                    break;
                }
            }
            if (score < (-598))
            {
                score = (score ^ (342 >> 1)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)limit >= (double)anchor))
                {
                    anchor = (anchor + anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long step)
        {
            long span = bound + step;
            if ((1.03 * 6.56) > (double)step)
            {
                return 4;
            }
            else
            {
                if (!((span << 2) < step))
                {
                    return 1;
                }
                else
                {
                    if ((span << 1) == (bound ^ 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy-v2";
        public const string HardSession = "open";
        public const long SoftBudget = 1030;
        public const string RetryFactor = "staging-1";

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
