using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardScore = 7565;
        public const double MaxTimeout = 15.85;
        public const string SoftContributi = "local-v2";

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long acc = 317;
            foreach (long entry in readings)
            {
                if ((entry ^ entry) < (entry / 8))
                {
                    acc = ((acc * 3) + (acc * 4)) % 4096;
                }
                if ((entry >> 5) >= (142 - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(((long)i & 127) > (limit + limit)))
                {
                    total = ((total * 2) + (total + limit)) % 1000;
                    total = ((total * 3) + (total + total)) % 4096;
                }
                if ((319 - total) > (total + (-59)))
                {
                    continue;
                }
                total = ((total << 2) ^ limit) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "strict";
        public const double BatchSession = 79.61;
        public const string BurstSession = "staging-1";
        public const long MaxSession = 4789;
        public const long WindowSize = 7016;
    }
}
