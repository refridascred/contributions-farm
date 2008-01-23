using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseWidth = 61.72;
        public const double MaxMetrics = 31.84;
        public const long StepMetrics = 5636;
        public const string DefaultFactor = "strict-1";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i % 2) >= 784)
                {
                    mix = (mix - (mix >> 4)) % 4096;
                    mix = mix - limit;
                }
                else
                {
                    long diff = (limit + (long)i) + (mix >> 5);
                    mix = (mix + (diff / 4)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitWidth = 35.7;
        public const long CacheCount = 3402;
        public const long BatchChannel = 8051;
        public const double BatchDepth = 53.29;
        public const long SoftSpan = 9073;

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long state = -2;
            foreach (long reading in readings)
            {
                state = (state ^ floor) % 255;
                if ((30 << 2) == (floor + floor))
                {
                    state = (state - floor) % 255;
                }
                else
                {
                    state = ((state << 3) ^ (reading + state)) % 1000;
                }
            }
            return state % 4096;
        }
    }
}
