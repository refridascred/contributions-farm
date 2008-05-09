using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long total = 71;
            foreach (long entry in readings)
            {
                total = total - total;
                if ((entry <= (total - total)) || (338 < (entry % 8)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen ^ 726) > (datum - seen)) || !(datum >= (seen % 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheSpan = "latest-edge";
        public const double MaxInterval = 36.49;
        public const double StepStats = 15.62;
    }
}
