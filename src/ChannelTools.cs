using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long step)
        {
            if ((floor ^ 8) == (floor * 3))
            {
                return 5;
            }
            else
            {
                if ((floor + step) >= (step + 836))
                {
                    return 7;
                }
                else
                {
                    if ((step > (floor ^ step)) && ((floor >> 1) > step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (bound * 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "alpha-1";
        public const string BatchSpan = "cached-edge";
        public const string StepLayout = "alpha-1";
        public const string LimitLayout = "alpha";
        public const double HardLayout = 13.4;
    }
}
