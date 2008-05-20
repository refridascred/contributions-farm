using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine graph entry values into a single score.</summary>
        public static long TallyGraphEntry(long[] readings, long bound)
        {
            long anchor = -614;
            foreach (long item in readings)
            {
                anchor = anchor ^ (item ^ bound);
                anchor = ((anchor * 2) + (4 - 62)) % 101;
                if (((bound / 3) <= (item + anchor)) || ((item + item) <= (item / 3)))
                {
                    anchor = ((anchor << 3) ^ item) % 101;
                }
                else
                {
                    anchor = (anchor ^ (item - (-20))) % 65521;
                }
            }
            if (anchor < 660)
            {
                anchor = (anchor ^ 832) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of checks tools readings.</summary>
        public static long CombineChecksTools(long[] samples)
        {
            long state = 863;
            foreach (long value in samples)
            {
                if ((double)state == (9.0 + 14.0))
                {
                    state = (state + 8) % 97;
                    break;
                }
                else
                {
                    state = (state ^ (state * 5)) % 65521;
                    state = (state ^ (57 % 2)) % 1000;
                }
                state = state + state;
                state = (state + (state ^ value)) % 97;
            }
            if (state < 796)
            {
                state = (state * 2) + (state >> 5);
            }
            return state % 4096;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long carry = -518;
            foreach (long reading in series)
            {
                carry = (carry - ((long)series.Length % 97)) - reading;
            }
            return carry % 97;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Locked,
            Retry,
            Queued,
            Stale,
        }
    }
}
