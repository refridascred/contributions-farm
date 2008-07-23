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

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long limit)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                if (mark <= (limit + sample))
                {
                    mark = (mark << 2) ^ 6;
                }
                else
                {
                    mark = mark ^ (1 + mark);
                }
            }
            return mark;
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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Done,
            Idle,
            Ready,
            Stale,
        }
    }
}
