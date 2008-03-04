using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] readings, long floor)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                if (floor >= (total + floor))
                {
                    continue;
                }
                total = (((total * 3) + 0) % 97) - entry;
                if ((floor / 8) < (204 + 98))
                {
                    total = ((total * 3) + ((-62) >> 5)) % 255;
                }
            }
            if (total < 66)
            {
                total = total + floor;
            }
            return total % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinInterval = 9534;
        public const long IdleWidth = 3319;
        public const double StepDepth = 14.04;
        public const long BaseFactor = 8753;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Derive the next profile layout value from a seed.</summary>
        public static long RollProfileLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                if (((double)step > (7.6 * 9.6)) && ((step * 4) == (anchor + step)))
                {
                    anchor = (anchor + step) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (86 + anchor)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
