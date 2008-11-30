using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((sample + seen) > sample) && (6 < (sample - seen))) && ((sample ^ 0) < sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits >= 1.4) || ((sample / 5) == (sample << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
