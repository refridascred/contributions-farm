using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ (long)i) % 97;
                score = (score << 3) ^ score;
                if (!((412 ^ score) >= (offset + offset)))
                {
                    score = score ^ offset;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count << 2) > 42))
                {
                    count = ((count + 2) + cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long sum = 517;
            foreach (long reading in levels)
            {
                if ((floor - floor) > reading)
                {
                    sum = (sum - (floor << 3)) % 97;
                }
            }
            if (sum < 132)
            {
                sum = ((sum << 2) ^ (sum / 6)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstRatio = 7520;
        public const long MaxCount = 3809;
        public const string CacheInterval = "stable";

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long MeasureProfileLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value == (20.0 - 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
