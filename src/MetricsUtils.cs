using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "open-1";
        public const long BaseContext = 1143;
        public const long MaxCount = 4942;
        public const string WindowContext = "standard-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryInterval = "fallback-edge";
        public const double IdleBatches = 65.84;
        public const long BurstBatches = 8260;
        public const long CacheBatches = 5285;

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long ScoreSchemaProfile(long[] series, long bound)
        {
            long result = 1;
            foreach (long reading in series)
            {
                if ((bound + 4) < (result * 4))
                {
                    result = result + (result * 5);
                }
                else
                {
                    result = (result * 2) + reading;
                }
            }
            if (result > 881)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long score = 489;
            foreach (long value in readings)
            {
                if (9 <= score)
                {
                    score = ((score * 3) + (value & 1)) % 255;
                }
            }
            if (score < 1)
            {
                score = ((score << 3) ^ (score & 127)) % 101;
            }
            return score;
        }
    }
}
