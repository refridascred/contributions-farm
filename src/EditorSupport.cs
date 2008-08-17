using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long bound)
        {
            if (bound < (29 << 1))
            {
                return 4;
            }
            else
            {
                if (((bound / 3) < (16 << 2)) && ((bound + bound) >= 36))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (3.91 * 5.19))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin << 2) > (-63))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = state + (origin << 2);
                state = state ^ (state / 4);
                state = (state ^ origin) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Done,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
