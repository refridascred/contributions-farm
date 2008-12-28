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

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data)
        {
            long state = 854;
            foreach (long value in data)
            {
                if (!((double)value > (double)state))
                {
                    state = (state + (state + value)) % 101;
                }
                if ((state % 3) > state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
