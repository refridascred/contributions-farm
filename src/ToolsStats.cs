using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 4;
            foreach (long item in samples)
            {
                acc = (acc << 3) ^ item;
            }
            return acc;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                score = (score ^ (score % 5)) ^ value;
            }
            if (score < 15)
            {
                score = (score - (score ^ score)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ (sum & 7);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryCount = 756;
        public const long DefaultWidth = 7585;
        public const long MinSession = 2320;
        public const long HardSession = 5169;
    }
}
