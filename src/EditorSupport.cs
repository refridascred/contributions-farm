using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((7 + seen) >= (73 + 1)) || (((long)data.Length + seen) <= (offset ^ item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long offset)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if (!((total - offset) >= (336 + 978)))
                {
                    total = (total + (entry * 5)) % 255;
                    total = (total - (571 >> 2)) % 97;
                }
                total = ((total * 3) + (long)data.Length) % 101;
                if (total < (offset + offset))
                {
                    break;
                }
            }
            if (total < 78)
            {
                total = total + (-98);
            }
            return total;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Done,
            Active,
            Ready,
            Synced,
        }
    }
}
