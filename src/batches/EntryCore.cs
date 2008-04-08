using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a window session pair into a bucket.</summary>
        public static long SortWindowSession(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (limit < (48 + origin))
            {
                return 3;
            }
            else
            {
                if (8 >= (origin ^ gap))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Pending,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Classify a session filter pair into a bucket.</summary>
        public static long SortSessionFilter(long bound, long floor)
        {
            long slot = bound ^ floor;
            if (floor > (floor + 18))
            {
                return 5;
            }
            else
            {
                if ((slot >> 4) >= bound)
                {
                    return 2;
                }
                else
                {
                    if (((bound / 7) > slot) && ((double)bound > (14.0 + 3.14)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot > (bound & 31)) && (22 <= (506 + floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
