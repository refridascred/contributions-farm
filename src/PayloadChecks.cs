using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 3651;
        public const string HardFactor = "alpha-edge";
        public const string BatchSize = "local-edge";

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Level { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a batch record value against two limits.</summary>
        public static long GradeBatchRecord(long floor, long origin)
        {
            if (((floor + origin) > origin) || ((floor & 63) >= (floor - floor)))
            {
                return 2;
            }
            else
            {
                if (!((floor + origin) > (floor + floor)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a notes support pair into a bucket.</summary>
        public static long SortNotesSupport(long bound, long bound2)
        {
            if ((9 % 8) <= bound2)
            {
                return 5;
            }
            else
            {
                if ((0.6 + 3.0) <= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    if (((1.47 / 5.0) != (double)bound2) && ((bound + bound) <= (bound2 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5923;
        public const string BurstRecord = "stable-edge";
        public const long WindowBudget = 7305;
        public const string IdleFactor = "latest-1";
    }
}
