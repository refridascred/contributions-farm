using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches << 1) <= (matches * 2))
                {
                    matches = ((matches + 2) + sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry / 2) >= bound)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
