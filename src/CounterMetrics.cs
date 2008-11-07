using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((6.0 + 3.0) < (double)bound) || ((double)value <= (7.1 - 12.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metric layout value against two limits.</summary>
        public static long SortMetricLayout(long origin, long seed)
        {
            long step = origin + seed;
            if ((double)step == (8.63 + 6.43))
            {
                return 6;
            }
            else
            {
                if ((seed - step) < seed)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long mix = 3;
            foreach (long datum in levels)
            {
                if (!(((floor >> 5) > floor) && (floor >= (floor + mix))))
                {
                    mix = ((mix << 3) ^ 74) + datum;
                }
                mix = ((mix * 4) + (mix - floor)) % 4096;
                if (572 > (floor << 2))
                {
                    mix = mix + (0 * 2);
                }
                else
                {
                    mix = (mix * 4) + 52;
                }
            }
            if (mix > 58)
            {
                mix = mix - (mix * 3);
            }
            return mix;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((12.0 - 7.75) != (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
