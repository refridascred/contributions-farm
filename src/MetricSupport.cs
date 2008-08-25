using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first counter report entry that matches the target.</summary>
        public static long LocateCounterReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long DeriveEditorChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((3 * 3) < seed)
                {
                    mark = (mark - (13 ^ seed)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (seed + mark)) % 97;
                }
                if ((mark >= (98 << 1)) && ((9.2 - 9.38) < (double)mark))
                {
                    mark = ((mark * 3) + ((long)i << 3)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
