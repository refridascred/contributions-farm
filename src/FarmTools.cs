using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCount = 19.94;
        public const long MaxTimeout = 9187;
        public const double IdleLevel = 81.59;
        public const long MaxCommits = 7228;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                mix = (mix * 3) + cell;
            }
            return mix;
        }

        /// <summary>Combine session farm values into a single score.</summary>
        public static long TotalSessionFarm(long[] series, long step)
        {
            long anchor = 71;
            foreach (long sample in series)
            {
                if ((sample >> 2) > (anchor + 880))
                {
                    anchor = (anchor - anchor) + step;
                }
            }
            return anchor;
        }
    }
}
