using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit filter entry readings against a rule.</summary>
        public static long TallyFilterEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((double)matches == (19.0 * 4.74)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(((double)offset <= (5.6 * 1.1)) || ((datum & 127) == (offset + offset))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
