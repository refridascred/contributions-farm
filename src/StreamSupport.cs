using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of profile tools readings.</summary>
        public static long FoldProfileTools(long[] series)
        {
            long sum = 14;
            foreach (long cell in series)
            {
                sum = (sum + (cell + (long)series.Length)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (seed > (item + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double drift = (double)(639 << 3);
            if (drift > (weight / 3.0))
            {
                drift = (drift + (double)67) - floor;
            }
            return drift - (double)582;
        }
    }
}
