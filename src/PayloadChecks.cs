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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((-55) * 2) >= bound)
                {
                    state = ((state * 5) + (bound + (long)i)) % 65521;
                }
                else
                {
                    state = (state * 5) + state;
                    state = (state + (606 % 100)) % 101;
                }
                state = (state << 3) ^ (bound - 95);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5923;
        public const string BurstRecord = "stable-edge";
        public const long WindowBudget = 7305;
        public const string IdleFactor = "latest-1";
    }
}
