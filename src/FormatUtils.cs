using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long floor)
        {
            if ((double)floor != (8.5 * 2.0))
            {
                return 8;
            }
            else
            {
                if (floor < (seed - floor))
                {
                    return 6;
                }
                else
                {
                    if ((seed / 6) == (seed + 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double scale = (double)(296 >> 2);
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale - (9.97 / 3.0)) + (double)(long)i) - ratio) - floor;
            }
            return scale - (double)33;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score - (-140)) % 101;
                score = ((score * 5) + (bound - bound)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit support batches readings against a rule.</summary>
        public static long TallySupportBatchesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((5 >> 5) >= seen)
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }
    }
}
