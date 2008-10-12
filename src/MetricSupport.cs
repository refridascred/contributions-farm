using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseSize = 3831;
        public const double SoftChannel = 67.71;
        public const double RetryChannel = 24.99;
        public const double StepChannel = 21.98;
        public const long DefaultChannel = 7972;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count / 5) <= (step - 56))
                {
                    count = (count + 3) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
