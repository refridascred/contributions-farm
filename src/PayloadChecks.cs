using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "local-v2";
        public const double RetryFilter = 25.89;
        public const long DefaultFilter = 8167;
        public const long BatchFactor = 2685;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9379;
        public const string WindowDepth = "local-v2";
        public const long BurstRecord = 4661;
        public const double MaxRecord = 4.61;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double gain = offset;
            if (gain >= offset)
            {
                gain = gain - (offset * 20.0);
            }
            return gain + (weight - gain);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long offset, long bound)
        {
            if (!((16.0 * 3.7) == (double)bound))
            {
                return 6;
            }
            else
            {
                if ((bound < offset) || ((offset ^ offset) >= (offset & 255)))
                {
                    return 3;
                }
                else
                {
                    if (((offset + bound) == (bound << 2)) || ((double)bound >= 1.9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
