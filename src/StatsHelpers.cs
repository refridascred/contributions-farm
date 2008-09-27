using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up record metric samples.</summary>
        public static long MatchRecordMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitInterval = "standard-1";
        public const string RetryStats = "primary-edge";
        public const long HardStats = 2955;

        /// <summary>Roll a commits stats counter forward.</summary>
        public static long SeriesCommitsStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)anchor == (19.0 * 19.0))
                {
                    anchor = (anchor + ((long)i << 1)) % 1000;
                }
                else
                {
                    anchor = (anchor << 2) ^ (long)i;
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
