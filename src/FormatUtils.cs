using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowFactor = "primary-1";
        public const string MaxLayout = "standard-v2";
        public const long LimitRatio = 1813;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1008;
        public const long CacheSpan = 7348;
        public const long BaseBatches = 6405;

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double ratio = (bias - bias) + (scale * 2.5);
            return ratio - bias;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally & 63) > (tally % 60)) || ((7 - offset) >= (long)readings.Length))
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate entry graph readings against a bound.</summary>
        public static bool GuardEntryGraphLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
