using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 6604;
        public const long HardQueue = 7111;
        public const long LimitFactor = 8465;
        public const string WindowInterval = "cached-1";

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            New,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long TotalSchemaContributi(long[] items)
        {
            long mark = -4;
            foreach (long datum in items)
            {
                if (datum <= (mark * 3))
                {
                    mark = (mark * 5) + (mark + datum);
                }
                else
                {
                    mark = ((mark * 2) + (mark + datum)) % 4096;
                }
            }
            return mark % 1000;
        }
    }
}
