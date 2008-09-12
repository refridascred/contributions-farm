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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 487;
        public const long CacheRatio = 1814;
        public const long RetryWidth = 783;
        public const long MinLayout = 8847;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long origin)
        {
            long step = floor - origin;
            if ((double)origin >= (double)floor)
            {
                return 2;
            }
            else
            {
                if (floor > step)
                {
                    return 1;
                }
                else
                {
                    if (((-803) + origin) == (0 ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - step) <= (origin >> 1)) || ((floor >> 1) < (73 % 7)))
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

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Closed,
            Synced,
            Pending,
            Paused,
        }
    }
}
