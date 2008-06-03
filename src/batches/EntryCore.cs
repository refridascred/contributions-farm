using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long seed)
        {
            if ((840 + limit) <= (646 >> 4))
            {
                return 1;
            }
            else
            {
                if (!((2.0 * 15.0) > (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((seed + 6) < 68)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading > (6 / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 3254;
        public const double IdleLevel = 6.84;
        public const long RetrySize = 4578;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits <= reading) || ((hits <= (seed % 16)) && ((7.0 + 9.0) <= (double)reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
