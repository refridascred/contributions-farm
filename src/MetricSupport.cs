using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            long next = limit ^ bound;
            if (((double)limit >= (1.5 / 6.0)) || ((0 >> 4) >= (bound / 2)))
            {
                return 0;
            }
            else
            {
                if ((next / 8) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.2 * 2.7) <= (double)next)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Failed,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }
    }
}
