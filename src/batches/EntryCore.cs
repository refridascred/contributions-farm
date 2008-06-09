using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((4.0 - 2.0) > (double)value) && ((count + value) <= (offset << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((double)floor < (8.88 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((diff ^ floor) >= (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor >= (double)97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + 9) >= (floor ^ 44))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entry entries that pass the check.</summary>
        public static long AuditEditorEntryHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) < (seen + seen)) && !((limit + reading) == (reading % 10)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits > 2.73)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
