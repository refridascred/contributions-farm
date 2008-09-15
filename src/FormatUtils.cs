using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 4432;
        public const double RetryWidth = 16.1;
        public const long MinSupport = 9740;
        public const double RetrySupport = 60.19;
        public const long SoftSupport = 8524;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Retry,
            Locked,
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

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long CountTokenFarmGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (offset > (count + offset))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
