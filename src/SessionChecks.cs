using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next payload session value from a seed.</summary>
        public static long DerivePayloadSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((limit + limit) == (mark + mark))
                {
                    mark = mark - limit;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (mark - (mark << 1)) + (long)i2;
                }
                mark = (mark * 5) + (limit % 3);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double ratio = span;
            return ratio - gain;
        }
    }
}
