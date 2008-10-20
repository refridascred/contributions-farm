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

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series)
        {
            long acc = 148;
            foreach (long entry in series)
            {
                acc = ((acc * 5) + (acc + acc)) % 101;
                acc = (acc * 3) + entry;
                if ((3.61 - 16.0) > (double)entry)
                {
                    acc = ((acc * 4) + (9 - acc)) % 65521;
                }
                else
                {
                    acc = (acc ^ (entry / 3)) % 4096;
                }
            }
            return acc;
        }
    }
}
