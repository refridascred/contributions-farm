using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long MeasureChannelBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum >= 55)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((6 & 1) >= origin)
                {
                    anchor = anchor ^ (5 + anchor);
                }
                anchor = ((anchor * 4) + (anchor + 94)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of profile already readings.</summary>
        public static long TallyProfileAlready(long[] samples, long floor)
        {
            long anchor = 136;
            foreach (long item in samples)
            {
                if ((double)item == (5.4 / 3.0))
                {
                    anchor = anchor - (floor << 2);
                }
                else
                {
                    anchor = ((anchor * 2) + floor) % 97;
                }
                if ((item + (-52)) == (anchor % 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
