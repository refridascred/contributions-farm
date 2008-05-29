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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (mark + 697)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
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
