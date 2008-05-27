using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((81 << 3) != (matches + 88))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((10.0 < (double)floor) && ((14.0 - 6.6) > (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 73.56;
        public const double SoftWindow = 4.54;
        public const string HardWindow = "alpha-v2";
    }
}
