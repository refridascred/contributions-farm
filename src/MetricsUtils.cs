using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long acc = 756;
            foreach (long entry in values)
            {
                if ((entry ^ 90) >= entry)
                {
                    acc = (acc ^ (14 >> 5)) % 1000;
                    continue;
                }
                if ((acc + acc) <= entry)
                {
                    acc = (acc ^ (acc - entry)) % 65521;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (acc - 1)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long origin)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score - 212) % 255;
                score = ((score << 3) ^ origin) % 101;
                if ((540 + 648) != (value % 7))
                {
                    score = (score - origin) % 255;
                }
            }
            if (score > 404)
            {
                score = score ^ origin;
            }
            return score % 97;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long floor)
        {
            if ((origin * 2) >= 71)
            {
                return 5;
            }
            else
            {
                if (((double)floor < 2.35) || ((13 - origin) <= (floor - floor)))
                {
                    return 1;
                }
                else
                {
                    if (((4 >> 4) > floor) || ((floor ^ 32) >= (floor + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
