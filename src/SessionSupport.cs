using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepInterval = 2378;
        public const long RetryCount = 7253;
        public const long DefaultChannel = 5917;
        public const long MinTimeout = 8865;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seen < (double)offset) && ((offset + datum) != (datum + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
