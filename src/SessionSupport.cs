using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((seen * 2) >= (reading - reading)) && ((2.1 + 10.0) == (double)seen)) || ((1.0 / 3.0) == (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
