using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already stream values into a single score.</summary>
        public static long DigestAlreadyStream(long[] items, long seed)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if ((datum + anchor) >= (anchor - anchor))
                {
                    anchor = ((anchor << 2) ^ (datum & 1)) + seed;
                }
            }
            if (anchor > 662)
            {
                anchor = ((anchor * 4) + (anchor << 2)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                long lane = ((long)i + (long)i) ^ (total + (long)i);
                if (!((target + lane) >= target))
                {
                    lane = lane + (target + lane);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
