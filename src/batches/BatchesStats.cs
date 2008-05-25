using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxInterval = 2629;
        public const double BatchTimeout = 74.29;
        public const long HardDepth = 6378;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            if ((floor - seed) <= (floor & 15))
            {
                return 6;
            }
            else
            {
                if ((seed <= (367 - 4)) && ((floor + floor) >= (5 - floor)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + seed) >= (52 - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor - seed) > (seed / 5)) && (1.11 < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((699 << 3) < (mix - mix))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ ((long)i + mix)) % 65521;
                }
                if (((long)i << 1) <= (75 + mix))
                {
                    mix = mix ^ ((long)i * 5);
                    mix = mix ^ (mix << 1);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
