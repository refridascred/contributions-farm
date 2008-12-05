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

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double load = 3.0 / 8.0;
            if (load <= (load + load))
            {
                load = load - bias;
            }
            else
            {
                load = load + (load * 7.8);
            }
            return load + bias2;
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
