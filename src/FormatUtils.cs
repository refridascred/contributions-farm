using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheCount = 4886;
        public const long BurstLayout = 8142;
        public const long MaxLayout = 526;
        public const long IdleRatio = 5361;
        public const double LimitLayout = 53.96;

        /// <summary>Scale a cluster contributi figure with a bias.</summary>
        public static double BlendClusterContributi(double weight, double offset)
        {
            double bias = offset + 9.2;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - 7.05;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (9.0 / 6.0)) + (double)(long)i;
            }
            return ratio - (ratio - bias);
        }

        /// <summary>Iterate the stream token series from a seed.</summary>
        public static long SeriesStreamToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result + (result & 63)) % 4096;
                result = (result << 3) ^ result;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score << 3) ^ (bound * 2)) ^ (long)i2;
                    score = score - score;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
