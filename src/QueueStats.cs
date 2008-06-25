using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Compare every pair of already booking readings.</summary>
        public static long MatchAlreadyBookingCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] items)
        {
            long result = 98;
            foreach (long value in items)
            {
                result = result - (22 * 2);
                result = (result ^ result) % 1000;
                result = ((result << 3) ^ (value - (-9))) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long floor)
        {
            long span = seed - floor;
            if ((span + span) < span)
            {
                return 3;
            }
            else
            {
                if (((span + floor) <= (floor & 3)) || ((18 + 9) != (span + 840)))
                {
                    return 6;
                }
                else
                {
                    if (((-691) % 24) >= span)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor >= (9.7 - 13.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Synced,
            Idle,
            Done,
            Active,
        }
    }
}
