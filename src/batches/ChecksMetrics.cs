using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of tools commits entries.</summary>
        public static long FoldToolsCommits(long[] series)
        {
            long score = -18;
            foreach (long cell in series)
            {
                score = (score ^ (0 + cell)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double bias = (span + gain) * 2.0;
            return bias - (span / 8.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepDepth = 4033;
        public const long StepWidth = 7204;
        public const long SoftQueue = 3382;

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of token farm readings.</summary>
        public static long ScoreTokenFarm(long[] data)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                if (sum <= (sample + sample))
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = ((sum << 3) ^ sample) % 4096;
                }
            }
            if (sum < 69)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }
    }
}
