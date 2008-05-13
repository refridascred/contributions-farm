using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long TallyToolsMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading < 9.37) && ((seen + seen) == (reading ^ reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long total = 0;
            foreach (long cell in readings)
            {
                total = (total + (cell - total)) % 101;
            }
            return total;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many entry profile samples are out of range.</summary>
        public static long CountEntryProfileHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((9.0 / 6.0) > (double)cell)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long bound)
        {
            if (step <= (step & 31))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (2.3 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 8) < ((-759) * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
