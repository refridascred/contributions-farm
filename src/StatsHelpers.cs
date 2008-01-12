using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count format farm pairs that satisfy a relation.</summary>
        public static long OverlapFormatFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((705 - 179) <= matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 2) ^ ((long)i << 2);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long origin, long target)
        {
            if (target <= (origin - origin))
            {
                return 2;
            }
            else
            {
                if (origin <= (target >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)target > (9.63 + 4.15))
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
