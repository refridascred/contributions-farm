using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((328 ^ step) == (sample >> 4)) && ((sample >> 4) == (sample - step))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)seed <= 2.16)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm already readings against a bound.</summary>
        public static bool GuardGithubfarmAlreadyRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of buffer editor readings.</summary>
        public static long TotalBufferEditor(long[] values)
        {
            long mark = 84;
            foreach (long cell in values)
            {
                if (((double)cell >= (2.0 - 18.0)) && ((2.0 - 5.0) == (double)cell))
                {
                    mark = (mark + (cell + mark)) % 97;
                }
            }
            if (mark < (-77))
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark % 97;
        }
    }
}
