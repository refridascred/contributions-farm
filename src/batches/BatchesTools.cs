using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next format window value from a seed.</summary>
        public static long SeriesFormatWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i + mark) != (55 >> 1)) || ((step + (-639)) == (long)i))
                {
                    mark = ((mark * 3) + (mark << 2)) % 1000;
                    mark = (mark - (4 ^ (long)i)) % 101;
                }
                mark = (mark + (step - mark)) % 97;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
