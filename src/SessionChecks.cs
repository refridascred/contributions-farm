using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + mark) % 97) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseTimeout = 398;
        public const string IdleLayout = "alpha";
        public const long BatchLayout = 1036;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long acc = 49;
            foreach (long entry in readings)
            {
                if ((acc + 25) > acc)
                {
                    acc = acc ^ entry;
                }
                if ((2.42 - 18.0) < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Failed,
            Pending,
            Done,
            Stale,
        }
    }
}
