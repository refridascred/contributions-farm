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

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 3992;
        public const long BatchRatio = 4689;
        public const long DefaultDepth = 6042;

        /// <summary>Match up cluster commits samples.</summary>
        public static long PairClusterCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
