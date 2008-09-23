using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count < (value % 64)) && ((value * 3) <= (3 * 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long floor)
        {
            long slot = target - floor;
            if (!((7 - target) > (target & 1)))
            {
                return 2;
            }
            else
            {
                if ((double)slot >= (0.12 + 5.2))
                {
                    return 3;
                }
                else
                {
                    if (slot >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] readings, long step)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                if (step < score)
                {
                    score = ((score + score) % 4096) + entry;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
