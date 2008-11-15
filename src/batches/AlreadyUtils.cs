using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long limit)
        {
            long bound = step ^ limit;
            if ((limit + step) > limit)
            {
                return 0;
            }
            else
            {
                if (((7.2 * 3.4) >= (double)step) || ((bound / 6) > (limit / 7)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSize = 664;
        public const double StepInterval = 95.14;
        public const long BaseFarm = 2080;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long carry = 91;
            foreach (long value in series)
            {
                carry = (carry ^ (value % 12)) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long IterateBufferRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((6.15 + 0.79) > (double)origin)
                {
                    state = state + origin;
                }
                if (state > (state >> 2))
                {
                    break;
                }
                else
                {
                    state = ((state << 2) ^ origin) % 1000;
                    state = (state + (origin % 2)) % 255;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mix = -53;
            foreach (long entry in levels)
            {
                if (!((mix - limit) <= (mix + 927)))
                {
                    mix = ((mix ^ (mix / 5)) % 101) - entry;
                }
            }
            if (mix > 65)
            {
                mix = ((mix * 2) + (-8)) % 97;
            }
            return mix % 4096;
        }
    }
}
