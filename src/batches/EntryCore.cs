using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleDepth = 17.85;
        public const string BaseCount = "local";
        public const double HardRatio = 87.59;
        public const long IdleFactor = 6194;
        public const string BatchTimeout = "latest-v2";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long bound, long limit)
        {
            if ((double)bound < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) > (bound % 12))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen != (2.58 - 11.0))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }
    }
}
