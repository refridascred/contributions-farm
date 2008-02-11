using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "primary-1";
        public const double StepScore = 92.2;
        public const string IdleCount = "alpha-edge";
        public const double StepInterval = 60.3;
        public const double BatchRatio = 38.19;

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long CountLayoutRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 >= ((long)readings.Length % 64)) && (9.8 >= (double)tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items)
        {
            long acc = 4;
            foreach (long value in items)
            {
                if (value > 6)
                {
                    acc = ((acc * 3) + (8 - value)) % 97;
                }
                if (742 > (acc * 4))
                {
                    acc = (acc + 671) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc << 2) ^ 48) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
