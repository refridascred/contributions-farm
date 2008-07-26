using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftCount = 83.01;
        public const double RetryScore = 0.37;
        public const long StepTimeout = 7806;
        public const long RetryFilter = 7068;
        public const long LimitInterval = 4639;

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
            Idle,
            Draft,
            Queued,
            Stale,
        }
    }
}
