using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((2.0 / 4.0) != (double)seed)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!!((long)i > (54 << 3)))
                {
                    acc = (acc + (106 * 4)) % 4096;
                }
                if ((limit & 31) < limit)
                {
                    acc = (acc * 3) + (830 - limit);
                }
                if (((limit - acc) <= 3) && ((limit + acc) >= (acc + limit)))
                {
                    acc = (acc - (limit - (long)i)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a report filter reading by value.</summary>
        public static long LocateReportFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
