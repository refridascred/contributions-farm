using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell >= (hits % 10))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long carry = 43;
            foreach (long item in samples)
            {
                if (((carry - carry) < carry) || ((4.2 - 1.6) > (double)carry))
                {
                    carry = (carry ^ (326 + carry)) + item;
                }
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen % 24) == (5 ^ 844))
                {
                    seen = ((seen + 2) + reading) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
