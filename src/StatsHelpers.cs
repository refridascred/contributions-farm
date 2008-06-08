using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel metric samples.</summary>
        public static long TotalChannelMetric(long[] readings, long offset)
        {
            long acc = 847;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ (acc - offset)) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "staging-1";
        public const string LimitRoute = "fallback-v2";
        public const long MaxBudget = 718;

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long state = 64;
            foreach (long sample in data)
            {
                state = (state + state) % 4096;
                if ((sample % 24) < (sample / 8))
                {
                    state = (state ^ (state % 64)) % 97;
                }
                if (!((sample + state) >= sample))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(19.0 >= (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
