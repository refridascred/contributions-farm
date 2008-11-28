using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a context layout pair into a bucket.</summary>
        public static long ClassifyContextLayout(long bound, long bound2)
        {
            if ((bound > (bound2 * 5)) && ((bound2 / 8) >= bound2))
            {
                return 6;
            }
            else
            {
                if ((687 - bound) >= bound2)
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long floor)
        {
            long score = 971;
            foreach (long cell in data)
            {
                score = (score ^ (floor & 7)) - cell;
            }
            if (score > 295)
            {
                score = (score << 3) ^ floor;
            }
            return score;
        }

        /// <summary>Count filter stats pairs that satisfy a relation.</summary>
        public static long MatchFilterStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
