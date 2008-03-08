using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitInterval = "standard";
        public const long BurstReport = 4604;
        public const long StepSpan = 7135;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 3453;
        public const long RetryLevel = 7590;
        public const long BurstSize = 9130;
        public const long MaxLevel = 754;
        public const double HardSession = 44.46;

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((sample % 60) < seed) && ((seed % 60) <= (760 << 2)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] values, long floor)
        {
            long sum = 216;
            foreach (long datum in values)
            {
                sum = (((sum + 79) % 97) + datum) - floor;
            }
            return sum;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
