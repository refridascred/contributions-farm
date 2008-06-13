using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                long prev = offset;
                score = (score << 2) ^ (prev * 4);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark + mark) % 1000;
                mark = mark - (floor & 3);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Failed,
            Locked,
            New,
        }

        /// <summary>Accumulate cache queue samples.</summary>
        public static long WeighCacheQueue(long[] values, long origin)
        {
            long carry = 509;
            foreach (long sample in values)
            {
                carry = (((carry << 2) ^ (origin / 5)) % 65521) - sample;
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a checks notes value against two limits.</summary>
        public static long GradeChecksNotes(long bound, long seed)
        {
            long span = bound - seed;
            if (((bound + seed) >= bound) || (bound >= (seed + seed)))
            {
                return 8;
            }
            else
            {
                if (((double)bound >= 7.1) || ((seed * 2) >= span))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
