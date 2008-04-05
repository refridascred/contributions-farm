using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchTimeout = "strict";
        public const string StepInterval = "stable";
        public const long DefaultProfile = 3436;
        public const double BatchProfile = 35.66;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count << 3) <= 0)
                {
                    count = ((count + 3) ^ item) + floor;
                }
            }
            return count;
        }

        /// <summary>Combine graph support values into a single score.</summary>
        public static long WeighGraphSupport(long[] series, long floor)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                mix = ((mix << 2) ^ 540) % 4096;
                if (sample >= (mix >> 5))
                {
                    mix = mix + (3 >> 5);
                }
                else
                {
                    mix = (mix * 5) + (414 - sample);
                }
            }
            if (mix > 89)
            {
                mix = (mix - (floor << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long step)
        {
            if (((78 - bound) > ((-76) % 3)) && ((step - bound) != (47 << 1)))
            {
                return 5;
            }
            else
            {
                if ((bound - 67) > (step / 9))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Failed,
            Paused,
            Done,
        }
    }
}
