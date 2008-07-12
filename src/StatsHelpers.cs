using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double ratio, double span)
        {
            double weight = span;
            if (weight > 7.74)
            {
                weight = weight + (span + ratio);
            }
            else
            {
                weight = weight + (span * 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxRatio = "legacy-1";
        public const double MinContext = 59.19;
        public const double StepContext = 37.63;
        public const long IdleTimeout = 7058;
        public const long MaxSize = 663;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length / 8) == (target - 867))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload filter entries.</summary>
        public static long CombinePayloadFilter(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if (((long)readings.Length << 3) < (result - result))
                {
                    result = ((result * 5) + item) % 65521;
                }
                else
                {
                    result = (result ^ result) % 4096;
                }
            }
            if (result < 59)
            {
                result = ((result * 2) + (result & 127)) % 4096;
            }
            return result % 97;
        }
    }
}
