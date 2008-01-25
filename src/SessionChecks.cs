using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long origin)
        {
            if ((double)origin <= (0.17 / 6.0))
            {
                return 4;
            }
            else
            {
                if ((floor << 3) >= (origin + origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 1) >= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((728 >> 4) <= floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 6628;
        public const string DefaultWidth = "strict-v2";
        public const double SoftBatch = 60.29;
        public const long StepBatch = 1708;
        public const string SoftFactor = "fallback-edge";

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
