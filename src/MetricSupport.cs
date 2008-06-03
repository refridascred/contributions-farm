using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a notes batches pair into a bucket.</summary>
        public static long BucketNotesBatches(long step, long seed)
        {
            if ((seed << 2) >= (step * 5))
            {
                return 6;
            }
            else
            {
                if ((step & 1) == ((-342) + step))
                {
                    return 8;
                }
                else
                {
                    if (seed <= ((-8) ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 35.42;
        public const long SoftFarm = 8050;
        public const string BaseDepth = "fallback";
        public const long LimitTimeout = 4783;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
