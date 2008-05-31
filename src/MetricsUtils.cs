using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score * 3) + (score * 5);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] series, long limit)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                anchor = anchor ^ limit;
                if ((datum + limit) < (anchor + 0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Draft,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 5158;
        public const long WindowSize = 9288;
        public const double BurstWidth = 44.97;
        public const double StepDepth = 51.5;
        public const long MaxFarm = 9808;

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRatio = 3753;
        public const long BatchWidth = 376;
        public const long BatchRoute = 7700;
        public const long BaseRoute = 4778;
    }
}
