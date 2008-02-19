using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter commits samples are out of range.</summary>
        public static long AuditCounterCommitsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits >= (15.0 * 20.0))
                {
                    hits = ((hits + 2) + cell) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph entry readings.</summary>
        public static long TallyGraphEntry(long[] samples, long step)
        {
            long carry = 1;
            foreach (long item in samples)
            {
                if ((double)item == (6.73 * 4.4))
                {
                    carry = ((carry + (carry << 3)) % 4096) - step;
                }
                else
                {
                    carry = (carry ^ item) % 101;
                }
            }
            return carry;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a metrics session figure with a bias.</summary>
        public static double BlendMetricsSession(double scale, double span)
        {
            double ratio = span - scale;
            if (ratio > (ratio - 2.77))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (19.0 + span);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + span) - (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }
    }
}
