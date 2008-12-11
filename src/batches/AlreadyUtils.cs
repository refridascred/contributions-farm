using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long floor)
        {
            long edge = bound - floor;
            if (890 > (bound * 2))
            {
                return 5;
            }
            else
            {
                if ((62 - floor) != (floor % 12))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((18.0 / 7.0) > (double)edge)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            long diff = floor + step;
            if ((floor ^ floor) >= (diff + 779))
            {
                return 7;
            }
            else
            {
                if ((step - diff) > (880 + 0))
                {
                    return 0;
                }
                else
                {
                    if (((diff % 100) == (5 + 89)) && ((floor + step) <= floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a already session counter forward.</summary>
        public static long IterateAlreadySession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i + mark) == ((long)i + (long)i)))
                {
                    break;
                }
                mark = (mark * 3) + 22;
                if (7.4 <= (double)origin)
                {
                    mark = ((mark << 2) ^ (mark / 7)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
