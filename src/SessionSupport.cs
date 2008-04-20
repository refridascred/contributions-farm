using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (7.0 <= (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the graph buffer series from a seed.</summary>
        public static long DeriveGraphBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark - ((long)i * 5)) % 97) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
