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

        /// <summary>Fold a list of record editor readings.</summary>
        public static long TotalRecordEditor(long[] items, long step)
        {
            long acc = 935;
            foreach (long datum in items)
            {
                if ((double)datum != (2.6 * 18.0))
                {
                    acc = (((acc * 5) + (acc + datum)) % 101) + step;
                }
                else
                {
                    acc = (acc - 69) % 4096;
                }
            }
            if (acc > 93)
            {
                acc = (acc + acc) % 97;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 3389;
        public const long BaseScore = 4983;
        public const string BurstStats = "fallback";
        public const string DefaultBudget = "cached-edge";
        public const long BaseSize = 7773;

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
