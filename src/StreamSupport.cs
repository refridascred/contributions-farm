using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate command format readings against a bound.</summary>
        public static bool VerifyCommandFormatLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - offset) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
