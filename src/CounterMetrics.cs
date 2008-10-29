using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long result = 846;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - ((long)i - 121)) % 97;
                }
                if ((datum / 8) >= (result / 8))
                {
                    result = (result << 3) ^ (result >> 2);
                }
            }
            return result % 97;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally + tally) <= reading)
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long bound)
        {
            long mark = 72;
            foreach (long item in samples)
            {
                mark = (mark << 2) ^ (item + item);
                if ((double)mark > (7.7 + 8.3))
                {
                    break;
                }
            }
            if (mark > 96)
            {
                mark = (mark + bound) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Dropped,
            Done,
        }
    }
}
