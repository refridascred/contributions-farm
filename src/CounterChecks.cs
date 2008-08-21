using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)limit < (10.0 * 2.25))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of payload editor readings.</summary>
        public static long OverlapPayloadEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if (!((floor - floor2) <= (floor - gap)))
            {
                return 3;
            }
            else
            {
                if ((3.84 / 8.0) >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a layout editor value against two limits.</summary>
        public static long ClassifyLayoutEditor(long step, long bound)
        {
            long delta = step ^ bound;
            if (delta <= 13)
            {
                return 0;
            }
            else
            {
                if ((bound * 5) <= (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (9.07 / 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((8.43 * 5.7) > (double)delta))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
