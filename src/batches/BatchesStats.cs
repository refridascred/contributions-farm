using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((score << 1) < floor)
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long result = 2;
            foreach (long value in levels)
            {
                if (1.9 <= (double)result)
                {
                    result = result ^ (value ^ result);
                }
                else
                {
                    result = result + (25 * 3);
                }
            }
            if (result > 46)
            {
                result = (result - ((-9) - 948)) % 1000;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 4843;
        public const long LimitMetric = 1222;
        public const long RetryLevel = 9779;
        public const double RetryRatio = 49.81;
        public const long BaseMetric = 2771;
    }
}
