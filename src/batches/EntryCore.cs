using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((18.0 + 10.0) >= (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next support counter value from a seed.</summary>
        public static long RollSupportCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long limit)
        {
            long prev = target + limit;
            if ((46 * 4) < (target - limit))
            {
                return 1;
            }
            else
            {
                if (target >= (prev & 7))
                {
                    return 0;
                }
                else
                {
                    if (((target ^ limit) <= (-62)) && ((target << 1) >= (limit & 15)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
