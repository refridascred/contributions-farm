using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value << 2) <= (value + 57)))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry > (matches >> 1)) || (entry >= (entry - entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (0.9 / 6.0))
            {
                bias2 = (bias2 - 17.0) + ratio;
            }
            return bias2 - (double)6;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
