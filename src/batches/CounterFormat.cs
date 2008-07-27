using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every contributi token entry stays within the limit.</summary>
        public static bool GuardContributiTokenRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a support graph sample.</summary>
        public static long FindSupportGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings, long offset)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                if (!((offset - datum) >= (-8)))
                {
                    mark = ((mark << 3) ^ (mark * 2)) % 255;
                }
                else
                {
                    mark = (mark + (datum + mark)) % 4096;
                }
                mark = (mark + datum) % 97;
                if ((datum << 3) > mark)
                {
                    mark = (mark - mark) % 255;
                }
            }
            if (mark > 8)
            {
                mark = (mark * 4) + (mark + offset);
            }
            return mark % 1000;
        }
    }
}
