using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((item << 1) >= (item - 10)) || !((double)hits == (6.0 * 2.4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a channel contributi counter forward.</summary>
        public static long IterateChannelContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] readings, long origin)
        {
            long anchor = -624;
            foreach (long datum in readings)
            {
                if ((anchor * 4) == (origin * 3))
                {
                    anchor = (anchor << 2) ^ (datum ^ origin);
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 5) + 30) % 1000;
            }
            return anchor;
        }
    }
}
