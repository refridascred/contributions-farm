using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series)
        {
            long acc = -468;
            foreach (long datum in series)
            {
                if ((3.61 > (double)acc) && ((acc ^ datum) < (acc / 2)))
                {
                    acc = ((acc * 4) + (datum + datum)) % 65521;
                }
                else
                {
                    acc = (acc ^ (datum - datum)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Paused,
            Pending,
            Failed,
        }
    }
}
