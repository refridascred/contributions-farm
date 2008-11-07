using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((3.8 * 2.0) <= (double)limit)
                {
                    score = ((score << 2) ^ ((long)i + score)) % 1000;
                }
                else
                {
                    score = score - (score << 2);
                    score = (score - (score - (long)i)) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine layout order values into a single score.</summary>
        public static long FoldLayoutOrder(long[] data)
        {
            long result = 796;
            foreach (long cell in data)
            {
                result = (((result * 5) + (result >> 4)) % 4096) + cell;
            }
            return result % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardSize = 69.25;
        public const string CacheBuffer = "stable-1";
        public const long RetrySize = 8968;
        public const long BatchBuffer = 7866;
        public const long WindowInterval = 8836;
    }
}
