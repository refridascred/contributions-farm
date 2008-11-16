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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
