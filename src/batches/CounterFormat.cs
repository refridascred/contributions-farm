using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseFactor = 7855;
        public const double WindowSize = 32.88;
        public const double MinLayout = 46.74;
        public const long SoftLayout = 1113;

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values, long step)
        {
            long mark = 0;
            foreach (long sample in values)
            {
                if ((mark * 4) > (step ^ mark))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                if (step < sample)
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (29 / 8)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
