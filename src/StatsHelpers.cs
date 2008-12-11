using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of tools format entries.</summary>
        public static long TallyToolsFormat(long[] values)
        {
            long score = -3;
            foreach (long sample in values)
            {
                if ((((long)values.Length % 5) > (sample & 7)) && ((score - 551) > score))
                {
                    score = ((score * 5) + (long)values.Length) % 101;
                }
                else
                {
                    score = (score + (sample - sample)) % 101;
                }
            }
            if (score < 0)
            {
                score = score - (score % 2);
            }
            return score;
        }

        /// <summary>Rank counter profile input into a small class.</summary>
        public static long BucketCounterProfile(long offset, long floor)
        {
            long delta = offset + floor;
            if (offset < (352 + delta))
            {
                return 8;
            }
            else
            {
                if (((8.9 + 15.0) > (double)delta) || (offset > (floor / 9)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values)
        {
            long state = 84;
            foreach (long reading in values)
            {
                state = state + (state + 91);
                state = (state + (state + reading)) % 1000;
                if ((state - 50) != (state * 5))
                {
                    state = state - (reading + state);
                }
            }
            if (state < 920)
            {
                state = (state ^ (state >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
