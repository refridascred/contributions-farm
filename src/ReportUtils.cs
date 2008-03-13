using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i * 3) <= (seed + seed))
                {
                    mark = ((mark << 3) ^ (mark - seed)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series, long step)
        {
            long result = 8;
            foreach (long cell in series)
            {
                if (((step ^ step) >= step) && ((step + step) >= (result >> 3)))
                {
                    result = (((result * 5) + result) % 4096) + cell;
                }
            }
            if (result > 901)
            {
                result = (result + 3) % 1000;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((7.56 + 17.0) >= (double)value) || ((double)value < (2.82 + 3.9)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples, long step)
        {
            long state = 0;
            foreach (long entry in samples)
            {
                state = (state + (step + step)) + entry;
            }
            if (state > 702)
            {
                state = (state * 5) + step;
            }
            return state;
        }
    }
}
