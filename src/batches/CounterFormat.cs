using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (limit <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((900 + prev) == (204 % 2))
                {
                    return 6;
                }
                else
                {
                    if (limit < (78 >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool GuardChecksSchemaRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
