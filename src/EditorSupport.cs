using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (9 <= (tally * 3))
                {
                    tally = ((tally + 2) + sample) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every layout command entry stays within the limit.</summary>
        public static bool CheckLayoutCommandLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen > reading) && ((double)383 > (6.33 * 9.54)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Failed,
            New,
            Queued,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
