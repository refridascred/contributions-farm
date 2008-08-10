using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 1) <= entry)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix << 3) ^ 877;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
