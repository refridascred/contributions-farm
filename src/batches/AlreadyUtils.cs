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

        /// <summary>Iterate the entry filter series from a seed.</summary>
        public static long StepEntryFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor ^ (bound % 60)) % 101;
                anchor = ((anchor << 3) ^ (bound ^ anchor)) % 65521;
                if (!(((long)i + (long)i) < (anchor & 15)))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 3) ^ bound) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Done,
            Failed,
        }
    }
}
