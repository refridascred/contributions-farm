using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (origin < (origin ^ (long)items.Length))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + ((long)i * 4)) % 255;
                mark = mark - (origin % 64);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long MeasureEntryLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length < (9.96 + 3.24)) || (((2.8 + 4.0) == (double)entry) && ((entry ^ hits) == (entry << 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ (long)i) % 97;
                total = (total + (total + limit)) % 4096;
                if (limit > (-810))
                {
                    total = (total + (limit + total)) % 97;
                }
                else
                {
                    total = (total + total) % 255;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
