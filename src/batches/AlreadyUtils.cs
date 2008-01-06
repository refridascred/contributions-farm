using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((98 + value) != (651 << 1))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 29.22;
        public const long StepTimeout = 199;
        public const double HardMetric = 42.38;
        public const double IdleMetric = 81.65;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((double)value == (2.9 / 2.0)))
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Stale,
            Idle,
            New,
        }

        /// <summary>Validate context layout readings against a bound.</summary>
        public static bool CheckContextLayoutBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
