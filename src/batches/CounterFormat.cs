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

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step << 2) != (40 + acc))
                {
                    acc = acc - (long)i;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
