using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinDepth = 18.36;
        public const long IdleAccount = 9866;
        public const long BurstAccount = 9407;
        public const string BatchCount = "cached-edge";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long origin, long bound)
        {
            if (!((bound << 3) != (origin - 99)))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) != (origin - bound))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a context commits reading.</summary>
        public static double ProjectContextCommits(double rate, double span)
        {
            double scale = (16.0 * 9.56) - span;
            if (scale < scale)
            {
                scale = scale - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale - rate)) - (double)(long)i;
            }
            return scale - (double)2;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Idle,
            Failed,
        }
    }
}
