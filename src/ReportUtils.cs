using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long AuditSchemaRecordMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((offset * 4) <= (hits & 3))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((total - total) == ((long)i - 14)) && ((total + (long)i) > ((long)i ^ total)))
                {
                    total = ((total * 5) + (total / 5)) % 4096;
                    break;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long seed, long bound)
        {
            if (24 >= (bound >> 5))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= 2.0)
                {
                    return 1;
                }
                else
                {
                    if (!((15.0 * 9.27) <= (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
