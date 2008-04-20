using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Pending,
            Done,
            Active,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 19.0)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series, long origin)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ (sum % 100)) + datum) - origin;
            }
            return sum % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
