using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long MeasureContextSchemaMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)step < (double)sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Queued,
            Done,
            Pending,
        }
    }
}
