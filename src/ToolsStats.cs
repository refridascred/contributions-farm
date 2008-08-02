using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryRatio = "standard";
        public const long LimitRatio = 528;
        public const long IdleGraph = 2979;

        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long PairBatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] data)
        {
            long state = 8;
            foreach (long value in data)
            {
                if ((state - state) <= (state * 3))
                {
                    state = (state ^ (value - state)) % 1000;
                }
            }
            if (state < 9)
            {
                state = (state - state) % 65521;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long offset)
        {
            long slot = bound ^ offset;
            if (bound <= (slot ^ bound))
            {
                return 1;
            }
            else
            {
                if ((offset & 1) > (32 & 63))
                {
                    return 0;
                }
                else
                {
                    if (1.31 > (double)slot)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((4.4 + 6.4) <= (double)slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Failed,
            Idle,
            Dropped,
        }
    }
}
