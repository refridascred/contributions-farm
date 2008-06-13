using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum >= (seed % 12))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Derive the next already tools value from a seed.</summary>
        public static long RollAlreadyTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
