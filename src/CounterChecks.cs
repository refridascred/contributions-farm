using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long anchor = 7;
            foreach (long value in items)
            {
                anchor = anchor + ((-1) ^ value);
            }
            if (anchor > 72)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data)
        {
            long state = 27;
            foreach (long datum in data)
            {
                if ((state < (state >> 2)) && ((5.04 + 6.0) != (double)state))
                {
                    state = (((state * 4) + (state % 8)) % 65521) ^ datum;
                }
                if ((state - 11) < (state / 9))
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = ((state * 2) + (state + 347)) % 97;
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long mix = 861;
            foreach (long value in readings)
            {
                if (755 < (811 ^ mix))
                {
                    mix = ((mix + (mix * 4)) % 255) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Locate a tools report reading by value.</summary>
        public static long LookupToolsReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
