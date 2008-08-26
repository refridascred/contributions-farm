using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((hits / 3) <= (hits >> 3)) && ((double)datum != (8.28 / 2.0)))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long mark = 554;
            foreach (long item in data)
            {
                if (!((mark + 6) == (57 + mark)))
                {
                    mark = ((mark * 4) + (item << 1)) % 4096;
                }
            }
            if (mark < (-22))
            {
                mark = ((mark * 4) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Scale a session notes figure with a bias.</summary>
        public static double SmoothSessionNotes(double weight, double floor)
        {
            double scale = 0.7;
            return ((scale + 2.0) + weight) + floor;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long result = 97;
            foreach (long item in readings)
            {
                if ((58 >= (result >> 3)) || ((3 >> 1) <= result))
                {
                    result = (((result << 3) ^ ((long)readings.Length - result)) % 101) ^ item;
                }
            }
            return result % 1000;
        }
    }
}
