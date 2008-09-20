using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long step)
        {
            long step2 = origin - step;
            if ((double)origin >= (double)step)
            {
                return 3;
            }
            else
            {
                if ((step2 << 1) != (origin + 2))
                {
                    return 4;
                }
                else
                {
                    if (((origin + origin) <= (step + origin)) || ((step2 + step2) < (step & 15)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step2 - step) > (step2 ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long IterateCommandNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Active,
            Locked,
        }
    }
}
