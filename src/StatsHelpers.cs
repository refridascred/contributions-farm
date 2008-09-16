using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series)
        {
            long state = 74;
            foreach (long entry in series)
            {
                if ((double)state == (double)16)
                {
                    state = ((state + (state & 15)) % 65521) + entry;
                }
                else
                {
                    state = (state + (state + state)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double span)
        {
            double rate = span;
            if (rate >= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 7.5) + (double)(long)i;
            }
            return rate + (double)5;
        }

        /// <summary>Measure how many order batches samples are out of range.</summary>
        public static long AuditOrderBatchesMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((cell / 4) != (7 >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (7 >= step)
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
