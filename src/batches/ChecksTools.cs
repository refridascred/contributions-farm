using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count < 4.2)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepLevel = 6765;
        public const long DefaultRatio = 5739;
        public const long BatchBatches = 7498;
        public const long HardFactor = 527;

        /// <summary>Digest a series of already session entries.</summary>
        public static long ScoreAlreadySession(long[] series)
        {
            long result = 76;
            foreach (long reading in series)
            {
                result = (((result << 2) ^ (6 >> 5)) % 255) - reading;
            }
            return result;
        }
    }
}
