using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) == (matches + matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long seed)
        {
            long delta = step + seed;
            if ((delta + seed) > seed)
            {
                return 0;
            }
            else
            {
                if ((seed - seed) >= (delta << 3))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 * 7.6) <= (double)delta)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxLevel = 1288;
        public const string BatchCommand = "local-edge";
        public const string SoftRatio = "strict-v2";
        public const long BaseCount = 6622;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Failed,
            Dropped,
            Active,
            New,
        }
    }
}
