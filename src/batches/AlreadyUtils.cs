using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Done,
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if (371 > (anchor & 7))
                {
                    anchor = ((anchor * 5) + (floor + anchor)) % 101;
                }
                else
                {
                    anchor = (anchor + (floor + anchor)) % 1000;
                    anchor = anchor - (floor << 3);
                }
                anchor = (anchor + (anchor >> 2)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSize = 5376;
        public const double CacheToken = 77.38;
        public const string WindowToken = "staging";
        public const long WindowInterval = 1736;

        /// <summary>Measure how many batch report samples are out of range.</summary>
        public static long AuditBatchReportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum - hits) != (hits / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
