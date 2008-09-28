using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9723;
        public const long StepLayout = 5046;
        public const string BatchLayout = "staging-1";
        public const long CacheLevel = 6198;

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                if ((entry >= (248 + anchor)) && ((anchor % 5) <= 5))
                {
                    anchor = (anchor ^ (entry + anchor)) % 1000;
                }
            }
            if (anchor < 275)
            {
                anchor = (anchor + (4 & 63)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
