using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Retry,
            New,
            Pending,
        }

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long TallyStatsCommitsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)seed >= (4.89 / 3.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long seed)
        {
            long carry = 755;
            foreach (long datum in data)
            {
                if ((7.0 - 9.5) != (double)seed)
                {
                    carry = (carry + (carry - datum)) % 1000;
                }
            }
            if (carry < 56)
            {
                carry = ((carry * 5) + (carry >> 1)) % 255;
            }
            return carry % 97;
        }
    }
}
