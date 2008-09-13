using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the channel command series from a seed.</summary>
        public static long DeriveChannelCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally + (-3)) <= tally) && ((tally & 1) == (tally ^ value)))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((6.0 / 7.0) <= (double)bound)
                {
                    anchor = ((anchor * 4) + (anchor ^ anchor)) % 97;
                }
                anchor = (anchor - (416 - (long)i)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Paused,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Idle,
            Retry,
        }
    }
}
