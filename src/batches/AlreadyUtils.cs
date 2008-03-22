using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftTimeout = "cached-edge";
        public const long BurstFilter = 1383;
        public const long SoftLevel = 6306;

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 3) ^ limit) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long MatchSupportFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ mix;
                if (!((origin & 1) != (mix - mix)))
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Stale,
            Draft,
            Dropped,
        }
    }
}
