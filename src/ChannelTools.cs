using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((offset >> 5) >= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
