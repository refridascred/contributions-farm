using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long limit)
        {
            long anchor = 40;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 3) ^ (entry + limit)) % 101;
                if (anchor < (anchor % 12))
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (anchor % 10);
                }
            }
            if (anchor > 110)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long AuditAccountBatchMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length <= (tally + target))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings, long origin)
        {
            long mark = 919;
            foreach (long item in readings)
            {
                mark = ((mark - item) % 97) + origin;
            }
            return mark;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ 43) > (tally & 31))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
