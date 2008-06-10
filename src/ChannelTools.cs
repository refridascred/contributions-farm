using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long floor)
        {
            long delta = origin - floor;
            if (!((delta + floor) == (floor + delta)))
            {
                return 6;
            }
            else
            {
                if (((delta + origin) >= (4 - delta)) && ((floor % 3) <= (origin / 2)))
                {
                    return 4;
                }
                else
                {
                    if (3.0 <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (delta > (origin + 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            New,
            Queued,
            Idle,
        }
    }
}
