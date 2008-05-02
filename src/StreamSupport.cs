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

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double drift = gain + 9.6;
            if (drift >= span)
            {
                drift = drift + drift;
            }
            return drift + (double)(-68);
        }
    }
}
