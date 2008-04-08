using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data, long step)
        {
            long mix = 0;
            foreach (long reading in data)
            {
                mix = ((((mix << 3) ^ (long)data.Length) % 65521) ^ reading) - step;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitLevel = 4459;
        public const string StepTimeout = "alpha-edge";
        public const long IdleAccount = 5310;
        public const string SoftAccount = "fallback";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
