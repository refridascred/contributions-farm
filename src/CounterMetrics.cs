using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = 81;
            foreach (long datum in items)
            {
                if ((32 + acc) > acc)
                {
                    acc = ((acc ^ (-351)) % 1000) ^ datum;
                }
            }
            if (acc > 214)
            {
                acc = acc ^ (acc - 2);
            }
            return acc;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((item >> 2) <= (39 ^ item)) && ((5.38 - 8.6) > (double)step)) && (((hits / 4) <= (-6)) || ((step ^ step) >= (0 + step))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 7259;
        public const long CacheBudget = 3784;
        public const string BaseWidth = "staging";
    }
}
