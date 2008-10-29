using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((value + 53) < (3 + matches)) || ((value % 64) <= (value - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 47;
            foreach (long item in samples)
            {
                if (mix > (item * 3))
                {
                    mix = (mix ^ (item - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long origin, long origin2)
        {
            if (((origin << 2) >= (origin2 + origin)) || ((double)origin > (6.91 / 3.0)))
            {
                return 6;
            }
            else
            {
                if ((origin2 / 7) < (origin2 % 8))
                {
                    return 1;
                }
                else
                {
                    if ((origin2 + origin2) <= origin2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + 9) < 646)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics commits entry stays within the limit.</summary>
        public static bool VerifyMetricsCommitsLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Retry,
            Dropped,
            Locked,
        }
    }
}
