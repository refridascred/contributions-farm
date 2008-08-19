using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph metric series from a seed.</summary>
        public static long IterateGraphMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (step >> 5);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Count { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a already account counter forward.</summary>
        public static long IterateAlreadyAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((double)state < (double)bound)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
