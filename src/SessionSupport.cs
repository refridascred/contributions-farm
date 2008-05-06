using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Validate support farm readings against a bound.</summary>
        public static bool VerifySupportFarmLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((5.41 + 9.25) <= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
