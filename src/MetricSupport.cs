using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many commits channel samples are out of range.</summary>
        public static long TallyCommitsChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)tally < (double)value) || ((double)value > (6.32 / 6.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseFactor = "strict-v2";
        public const long MinCluster = 5474;
        public const long LimitCluster = 2133;
        public const long BaseScore = 6539;
        public const long LimitDepth = 214;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                mark = ((mark + (975 & 7)) % 97) ^ reading;
            }
            return mark % 4096;
        }
    }
}
