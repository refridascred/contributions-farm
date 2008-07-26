using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two checks filter measurements.</summary>
        public static double BlendChecksFilter(double rate, double floor)
        {
            double mean = floor + 6.5;
            if (mean <= (double)581)
            {
                mean = mean - (rate + mean);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (floor * 5.87)) - (double)(long)i;
            }
            return mean + (double)(-2);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long mark = 4;
            foreach (long value in data)
            {
                mark = ((mark + mark) % 1000) + value;
            }
            if (mark < 621)
            {
                mark = (mark * 4) + (3 ^ mark);
            }
            return mark;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Done,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel checks samples are out of range.</summary>
        public static long AuditChannelChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(hits >= (entry + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
