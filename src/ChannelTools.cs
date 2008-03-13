using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Locked,
            New,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long limit2)
        {
            if ((5.55 - 4.4) == (double)limit2)
            {
                return 8;
            }
            else
            {
                if ((double)limit2 > 3.8)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (7.2 * 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (limit2 * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Failed,
            Stale,
            Queued,
            New,
        }
    }
}
