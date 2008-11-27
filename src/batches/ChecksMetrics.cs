using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next report entry value.</summary>
        public static double BlendReportEntry(double rate, double offset)
        {
            double ratio = (double)(7 + (-360));
            return ((ratio + (double)89) + rate) + offset;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally / 4) == (tally % 100)) || !((double)tally != (1.0 - 6.6)))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue context readings.</summary>
        public static long TotalQueueContext(long[] samples, long offset)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                mark = (((mark << 3) ^ (mark - mark)) + item) - offset;
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((offset ^ 626) > (matches / 9))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((4.0 - 6.7) == (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
