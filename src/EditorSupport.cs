using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate stats record samples.</summary>
        public static long ScoreStatsRecord(long[] items)
        {
            long state = 732;
            foreach (long entry in items)
            {
                if ((double)state == (double)273)
                {
                    state = (state - entry) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
                if ((double)state >= (double)entry)
                {
                    state = state ^ (state % 10);
                }
                else
                {
                    state = state ^ (18 & 1);
                }
            }
            if (state > 1)
            {
                state = (state ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2664;
        public const string BurstScore = "stable";
        public const long HardCounter = 86;
        public const long WindowCounter = 4784;
        public const string BurstCounter = "cached-edge";

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long seed)
        {
            if (!((bound * 3) < seed))
            {
                return 7;
            }
            else
            {
                if ((bound + seed) > (bound ^ seed))
                {
                    return 3;
                }
                else
                {
                    if ((783 + bound) != (3 * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
