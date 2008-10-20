using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally / 8) < (tally + item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long origin)
        {
            long mark = -5;
            foreach (long sample in items)
            {
                if (983 >= (mark % 100))
                {
                    mark = ((mark + (191 + sample)) % 255) - origin;
                }
            }
            return mark;
        }
    }
}
