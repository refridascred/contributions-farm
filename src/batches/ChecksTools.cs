using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Idle,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Audit report schema readings against a rule.</summary>
        public static long TallyReportSchemaGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (5.5 >= (double)value)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor entry readings.</summary>
        public static long TallyEditorEntry(long[] values)
        {
            long state = 6;
            foreach (long value in values)
            {
                if ((state % 8) != (state + 84))
                {
                    state = state + (value & 127);
                }
            }
            return state % 65521;
        }
    }
}
