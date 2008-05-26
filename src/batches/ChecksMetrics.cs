using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const double MaxStats = 30.5;
        public const long SoftLevel = 199;

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 73.87;
        public const long MinSpan = 823;
        public const long RetryBudget = 2100;
        public const long CachePayload = 4972;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 2784;
        public const long BatchDepth = 8004;
        public const string IdleSize = "open-1";

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] items, long origin)
        {
            long score = 479;
            foreach (long entry in items)
            {
                score = (score ^ (entry + entry)) % 97;
                score = (score << 2) ^ (origin - score);
                if ((double)entry != (5.59 + 20.0))
                {
                    score = ((score << 2) ^ (origin + 622)) % 1000;
                }
                else
                {
                    score = (score + (7 + origin)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long bound)
        {
            long delta = floor ^ bound;
            if (((bound >> 2) > (280 + delta)) && ((2.82 + 2.0) <= (double)floor))
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (9.5 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound + delta) <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor <= (5.52 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
