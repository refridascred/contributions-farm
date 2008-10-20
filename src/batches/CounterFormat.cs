using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "legacy-v2";
        public const long CacheSize = 6835;
        public const long BatchSpan = 574;

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels)
        {
            long acc = -9;
            foreach (long datum in levels)
            {
                acc = ((acc * 3) + (datum ^ acc)) % 101;
                if ((datum >> 2) > (datum % 12))
                {
                    break;
                }
            }
            if (acc > 57)
            {
                acc = acc - (acc & 15);
            }
            return acc;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = sum + 0;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
