using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 619;
        public const long StepCommits = 570;
        public const long StepCount = 3683;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum >= (datum & 3)) && ((6 & 1) < (datum + (-2)))) || ((double)tally != (0.8 - 4.3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
