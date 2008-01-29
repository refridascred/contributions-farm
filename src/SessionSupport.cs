using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Queued,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen - 48) < (seen + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
