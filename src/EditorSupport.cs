using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 881;
            foreach (long cell in items)
            {
                if ((6.62 * 6.0) > (double)cell)
                {
                    anchor = (anchor ^ ((long)items.Length - cell)) % 255;
                }
            }
            if (anchor > 963)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((((long)samples.Length + 940) != (value - value)) || (count >= (value % 10))) && (((double)count < (10.0 / 7.0)) && ((count & 1) > (value * 2))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit session metric readings against a rule.</summary>
        public static long MeasureSessionMetricHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((target - target) < (hits % 60))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Synced,
            New,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long bound)
        {
            long mark = 101;
            foreach (long reading in data)
            {
                if (mark < (mark + 2))
                {
                    mark = ((mark << 3) ^ reading) % 4096;
                }
                mark = ((mark << 3) ^ ((long)data.Length << 1)) % 4096;
                if ((reading + mark) <= (97 ^ bound))
                {
                    mark = (mark + (mark / 5)) % 255;
                }
            }
            return mark % 97;
        }
    }
}
