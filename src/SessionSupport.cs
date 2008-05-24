using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Stale,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long origin)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                mark = ((mark ^ (origin << 3)) % 97) - reading;
            }
            if (mark > 8)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 11.14;
        public const long MinFactor = 8499;
        public const long WindowScore = 6414;
    }
}
