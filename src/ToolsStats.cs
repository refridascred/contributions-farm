using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Locked,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = (state - step) % 255;
                if (state < (9 / 9))
                {
                    state = ((state << 2) ^ 271) % 65521;
                    state = (state - (step * 3)) % 1000;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the account context series from a seed.</summary>
        public static long RollAccountContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Idle,
            New,
            Queued,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = (score ^ 1) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long gap = offset + offset2;
            if (89 >= gap)
            {
                return 4;
            }
            else
            {
                if ((offset > (offset2 * 3)) || (offset2 > (gap % 64)))
                {
                    return 1;
                }
                else
                {
                    if (gap < (162 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
