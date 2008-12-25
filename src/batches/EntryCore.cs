using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine report context values into a single score.</summary>
        public static long CombineReportContext(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = ((mark ^ ((long)readings.Length - mark)) % 65521) + datum;
                mark = ((mark * 3) + (mark + 49)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long seed)
        {
            long mark = 1;
            foreach (long entry in data)
            {
                mark = mark + (entry + seed);
            }
            return mark;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long origin)
        {
            if ((0.1 >= (double)limit) && ((limit - 7) < (origin - origin)))
            {
                return 0;
            }
            else
            {
                if ((limit & 31) <= (limit & 63))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool VerifyReportNotesBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
