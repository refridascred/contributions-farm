using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > (value - 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3.3 / 2.0) > (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Done,
            Pending,
            Ready,
            Idle,
        }
    }
}
