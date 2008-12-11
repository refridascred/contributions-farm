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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((2 <= (entry - entry)) && ((8 / 8) == (entry ^ tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
