using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = bias2 - (2.99 * 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - offset) - (double)(long)i;
            }
            return bias2 + (4.5 + 2.27);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 9071;
        public const string BatchCommits = "fallback-v2";
        public const double MaxScore = 6.55;

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > (double)(-9))
            {
                gain2 = gain2 - (double)(-62);
            }
            else
            {
                gain2 = gain2 + 6.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (gain / 6.0)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

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

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
