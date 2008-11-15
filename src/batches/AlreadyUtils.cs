using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long limit)
        {
            long bound = step ^ limit;
            if ((limit + step) > limit)
            {
                return 0;
            }
            else
            {
                if (((7.2 * 3.4) >= (double)step) || ((bound / 6) > (limit / 7)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Queued,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 655;
        public const long MinNotes = 5989;
        public const double MinSize = 82.57;
        public const long MaxNotes = 1908;

        /// <summary>Adjust a tools context reading.</summary>
        public static double AdjustToolsContext(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= bias2)
            {
                scale = scale - (bias2 - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (12.0 - scale)) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double ratio = scale + (offset + 8.0);
            if (ratio >= (double)16)
            {
                ratio = ratio - (scale + ratio);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)77) + (double)(long)i;
            }
            return ratio - (scale + offset);
        }
    }
}
