using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed + mix) > seed)
                {
                    mix = (mix * 3) + (75 / 4);
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen > 6.96)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }
    }
}
