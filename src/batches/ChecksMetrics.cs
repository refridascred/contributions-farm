using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Score { get; set; }
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

        /// <summary>Validate format stats readings against a bound.</summary>
        public static bool ValidateFormatStatsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
