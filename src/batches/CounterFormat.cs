using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order stats readings.</summary>
        public static long DigestOrderStats(long[] readings, long step)
        {
            long anchor = 404;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 2) + (step + cell)) % 65521;
            }
            if (anchor < 23)
            {
                anchor = (anchor << 2) ^ (step - step);
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2140;
        public const long BatchStats = 9225;
        public const long IdleTimeout = 9159;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items, long origin)
        {
            long score = -166;
            foreach (long cell in items)
            {
                score = (((score << 2) ^ origin) % 97) - cell;
            }
            if (score > 180)
            {
                score = (score * 4) + (score / 3);
            }
            return score % 4096;
        }
    }
}
