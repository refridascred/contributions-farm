using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Synced,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long offset)
        {
            long diff = seed - offset;
            if (((3.5 * 6.79) <= (double)seed) || ((diff >> 5) <= diff))
            {
                return 7;
            }
            else
            {
                if ((diff ^ offset) <= 898)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long floor2)
        {
            if ((floor + floor2) != (floor >> 4))
            {
                return 0;
            }
            else
            {
                if ((floor >= floor2) && (floor2 < (floor / 9)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
