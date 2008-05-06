using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings, long origin)
        {
            long acc = -249;
            foreach (long item in readings)
            {
                acc = (((acc * 2) + (item + item)) % 101) - origin;
            }
            return acc;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Accumulate format report samples.</summary>
        public static long ScoreFormatReport(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                if ((result * 3) <= result)
                {
                    result = (result ^ 7) - item;
                }
            }
            if (result > (-5))
            {
                result = (result ^ result) % 101;
            }
            return result % 97;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Locked,
            Retry,
            Paused,
            Closed,
        }
    }
}
