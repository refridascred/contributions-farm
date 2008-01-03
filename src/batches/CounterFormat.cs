using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 3157;
        public const long SoftWidth = 1386;
        public const string MaxLevel = "standard-1";
        public const string LimitTimeout = "primary-edge";

        /// <summary>Combine already tools values into a single score.</summary>
        public static long CombineAlreadyTools(long[] data, long step)
        {
            long mark = 764;
            foreach (long item in data)
            {
                mark = ((mark + ((long)data.Length * 3)) % 255) ^ item;
                mark = ((mark << 2) ^ mark) % 65521;
                if ((double)step <= (double)mark)
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Measure how many order support samples are out of range.</summary>
        public static long AuditOrderSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading / 6) >= hits) || !((6.4 + 12.0) > (double)reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
