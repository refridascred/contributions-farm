using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up notes report samples.</summary>
        public static long PairNotesReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepNotes = 51.63;
        public const string DefaultInterval = "alpha-1";
        public const long RetryNotes = 3209;
        public const double CacheNotes = 73.03;

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
