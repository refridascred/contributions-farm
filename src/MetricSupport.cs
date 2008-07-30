using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score + (bound + bound)) ^ (long)i2;
                }
                if ((7 / 4) > (bound >> 1))
                {
                    score = score ^ ((long)i + bound);
                    continue;
                }
                else
                {
                    score = score + (bound / 2);
                }
                score = (score << 3) ^ (5 % 16);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstCount = 36.85;
        public const string SoftToken = "standard-edge";
        public const long RetryToken = 5493;
    }
}
