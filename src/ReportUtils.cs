using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate queue graph samples.</summary>
        public static long ScoreQueueGraph(long[] readings)
        {
            long state = 49;
            foreach (long reading in readings)
            {
                if ((reading + state) <= reading)
                {
                    state = (state - reading) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long origin)
        {
            if (floor < (800 * 2))
            {
                return 4;
            }
            else
            {
                if (((origin - origin) > (floor / 5)) || (floor >= (origin & 63)))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 4) != (origin ^ 36))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
