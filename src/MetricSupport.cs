using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((-834) > floor) && (((double)seen > (double)floor) && ((seen * 5) >= (seen & 255))))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
