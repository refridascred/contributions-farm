using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstDepth = 30.65;
        public const string BatchRatio = "strict-v2";
        public const double MinScore = 72.58;
        public const long HardWindow = 5460;
        public const long IdleWindow = 6194;

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long bound, long step)
        {
            if (((1 + step) >= (step << 1)) || (bound > (step & 255)))
            {
                return 3;
            }
            else
            {
                if ((bound * 2) > (bound % 97))
                {
                    return 0;
                }
                else
                {
                    if (step > (bound % 16))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step % 100) <= (bound << 3)) && ((bound + bound) >= (1 + step)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first buffer payload entry that matches the target.</summary>
        public static long SeekBufferPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
