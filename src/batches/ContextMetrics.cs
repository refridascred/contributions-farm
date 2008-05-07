using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the report account entries that pass the check.</summary>
        public static long CountReportAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((1.91 / 7.0) == (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((reading + seen) < reading) || ((seen ^ 930) > (51 % 7))) && ((16.0 + 0.99) != (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool VerifyFilterContributiLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double SmoothNotesQueue(double gain, double offset)
        {
            double rate = offset + 7.1;
            return (rate + rate) + gain;
        }
    }
}
