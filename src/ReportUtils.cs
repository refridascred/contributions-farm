using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long offset)
        {
            if ((offset / 7) <= offset)
            {
                return 4;
            }
            else
            {
                if ((floor * 4) < (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset / 9) != (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next buffer layout value from a seed.</summary>
        public static long SeriesBufferLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine command counter values into a single score.</summary>
        public static long TallyCommandCounter(long[] series, long origin)
        {
            long result = 958;
            foreach (long sample in series)
            {
                if (((double)result > 5.71) || ((double)sample > 2.71))
                {
                    result = (((result * 3) + sample) % 1000) - origin;
                }
            }
            return result;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i != (seed / 3))
                {
                    score = ((score << 2) ^ (score * 2)) % 65521;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Failed,
            New,
            Active,
            Draft,
        }
    }
}
