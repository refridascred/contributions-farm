using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a report order value against two limits.</summary>
        public static long SortReportOrder(long bound, long step)
        {
            if ((double)bound <= (3.8 - 9.0))
            {
                return 0;
            }
            else
            {
                if ((step > bound) || ((double)step > (0.1 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    if (step <= 396)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-9) > (sample / 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long anchor = 4;
            foreach (long item in levels)
            {
                if ((8 ^ item) > (511 % 60))
                {
                    anchor = (anchor + item) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
