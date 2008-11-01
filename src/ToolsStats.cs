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

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Retry,
            Pending,
            Paused,
        }

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

        /// <summary>Derive the next account channel value from a seed.</summary>
        public static long StepAccountChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
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
