using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate cluster checks samples.</summary>
        public static long TallyClusterChecks(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                mix = mix ^ ((long)samples.Length + datum);
                if ((datum * 2) > (datum << 3))
                {
                    mix = (mix ^ (datum + datum)) % 101;
                }
            }
            if (mix > 407)
            {
                mix = (mix * 2) + (mix * 4);
            }
            return mix;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 2169;
        public const double StepTimeout = 44.55;
        public const double CacheSize = 46.55;
        public const long MaxRoute = 2153;
        public const double DefaultRoute = 76.22;
    }
}
