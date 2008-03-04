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

        /// <summary>Validate batch report readings against a bound.</summary>
        public static bool GuardBatchReportRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
