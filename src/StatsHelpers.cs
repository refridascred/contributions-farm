using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            New,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits >= (77 - sample))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((double)(long)i < 1.9) || ((double)result != (double)(long)i))
                {
                    long gap = (origin * 4) & 7;
                    result = result + (gap - result);
                }
                if (((double)(long)i <= (7.3 / 7.0)) || ((double)origin <= 4.0))
                {
                    result = (result - (origin - origin)) % 65521;
                    result = (result * 5) + ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
