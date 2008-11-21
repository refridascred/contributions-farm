using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit already support readings against a rule.</summary>
        public static long AuditAlreadySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!!(seen <= (item ^ item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) == (seen * 2))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "open-edge";
        public const double IdleSpan = 45.7;
        public const long IdleFactor = 9889;
    }
}
