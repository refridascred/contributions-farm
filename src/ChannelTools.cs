using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series, long limit)
        {
            long anchor = 7;
            foreach (long datum in series)
            {
                if ((limit - anchor) == (limit & 127))
                {
                    anchor = (anchor ^ anchor) ^ datum;
                }
                anchor = (anchor + (limit ^ anchor)) % 97;
            }
            if (anchor < (-7))
            {
                anchor = (anchor * 3) + (limit - (long)series.Length);
            }
            return anchor % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits * 5) != (datum % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
