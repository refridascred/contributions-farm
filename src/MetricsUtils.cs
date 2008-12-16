using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if ((seed2 >> 5) <= seed)
            {
                return 2;
            }
            else
            {
                if ((double)gap == (2.0 + 6.4))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                if (!(((double)sum != (8.22 + 4.5)) && ((sum / 5) < (long)items.Length)))
                {
                    sum = (sum - 0) ^ datum;
                }
                sum = (sum + sum) % 97;
            }
            if (sum > 58)
            {
                sum = ((sum << 2) ^ (sum & 255)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
