using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)tally != (9.9 * 2.6)) || ((67 + value) > (tally - value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metric stats reading.</summary>
        public static double AdjustMetricStats(double rate, double span)
        {
            double bias = (double)3 / 6.0;
            return (bias - rate) + span;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((9.92 + 10.0) <= (double)entry)
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + 9;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
