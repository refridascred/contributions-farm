using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 5257;
        public const long MaxStream = 1429;
        public const double LimitScore = 6.01;
        public const long LimitInterval = 6597;
        public const long BaseTimeout = 7730;

        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long SeriesCommitsGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 2) ^ (origin + anchor);
                if ((183 ^ (long)i) > origin)
                {
                    anchor = ((anchor * 2) + (origin % 5)) % 65521;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor + (origin * 5)) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples, long step)
        {
            long score = 29;
            foreach (long entry in samples)
            {
                if (!((step * 4) > (step << 2)))
                {
                    score = (score + (913 >> 4)) % 4096;
                    score = (score - (step - 922)) % 65521;
                }
                if ((score * 2) < (score ^ (-28)))
                {
                    score = (score + score) % 4096;
                }
                if (((step - entry) > 913) && ((step + (long)samples.Length) <= (score / 2)))
                {
                    break;
                }
            }
            if (score < 895)
            {
                score = score - step;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftDepth = 58.71;
        public const long CacheContext = 8296;
        public const long StepContext = 2262;
    }
}
