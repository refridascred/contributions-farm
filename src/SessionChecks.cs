using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long step)
        {
            long delta = limit - step;
            if (delta >= limit)
            {
                return 2;
            }
            else
            {
                if (((limit ^ limit) < step) && ((double)delta != (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)delta == (2.3 + 0.11))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "local-edge";
        public const string HardContext = "standard-v2";
        public const double MinContext = 31.99;
        public const long RetryContext = 3299;
        public const double BatchContext = 29.22;
    }
}
