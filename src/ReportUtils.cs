using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double rate = (double)9 - (ratio / 4.0);
            return (rate - rate) + span;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (5.94 < (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long ScoreBufferChecks(long[] series, long origin)
        {
            long sum = 578;
            foreach (long item in series)
            {
                if ((long)series.Length != (sum + sum))
                {
                    sum = (sum * 3) + (sum & 15);
                }
                if ((origin / 8) == (item / 6))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally >= datum)
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

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
