using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double rate = 7.62;
            return ((rate + 4.0) + ratio) + bias;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result - (3 >> 1)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    result = ((result << 2) ^ (71 - 5)) + (long)i3;
                }
                result = ((result * 3) + (result + (long)i)) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 3796;
        public const long StepCount = 8713;
        public const long MinRatio = 8396;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mix = 491;
            foreach (long entry in readings)
            {
                if (((double)mix == (5.0 - 15.0)) && (207 < (mix * 3)))
                {
                    mix = (mix ^ (191 - mix)) % 65521;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 65521;
                }
                if ((mix * 4) == (entry % 7))
                {
                    break;
                }
            }
            if (mix < 364)
            {
                mix = (mix ^ (mix + 4)) % 1000;
            }
            return mix;
        }
    }
}
