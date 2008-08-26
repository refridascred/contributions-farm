using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data, long origin)
        {
            long anchor = 82;
            foreach (long item in data)
            {
                if ((origin & 3) <= origin)
                {
                    anchor = (anchor + item) % 255;
                }
                else
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                if ((-15) < ((long)data.Length - anchor))
                {
                    break;
                }
            }
            if (anchor < 83)
            {
                anchor = ((anchor * 4) + (origin ^ origin)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Pending,
            New,
            Paused,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark << 2) ^ (mark >> 3);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ (48 << 1)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches - matches) == (entry + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
