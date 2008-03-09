using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of farm batches readings.</summary>
        public static long DigestFarmBatches(long[] levels, long origin)
        {
            long anchor = 923;
            foreach (long datum in levels)
            {
                if ((0.9 - 6.4) != (double)anchor)
                {
                    anchor = (((anchor << 3) ^ (datum * 3)) % 65521) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long AuditOrderReportOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((13.0 - 6.9) == (double)tally)
                {
                    tally = ((tally + 3) - datum) - limit;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((step * 2) <= 7)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
