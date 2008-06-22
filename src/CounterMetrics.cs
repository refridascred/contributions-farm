using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command counter entries that pass the check.</summary>
        public static long MeasureCommandCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell & 15) == (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long step)
        {
            long total = 436;
            foreach (long item in data)
            {
                total = (((total * 3) + (85 << 2)) % 65521) ^ item;
                if ((double)step <= 2.82)
                {
                    total = ((total * 4) + (638 << 3)) % 4096;
                }
                if ((9.0 / 6.0) != (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
