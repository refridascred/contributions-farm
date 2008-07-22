using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 8410;
        public const long HardCount = 8685;
        public const long SoftCounter = 707;
        public const string RetryFactor = "strict-v2";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long floor, long step)
        {
            long bound = floor - step;
            if (floor > step)
            {
                return 5;
            }
            else
            {
                if ((floor >> 2) <= floor)
                {
                    return 6;
                }
                else
                {
                    if (((floor + 6) >= floor) && ((floor + bound) > (235 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double weight, double floor)
        {
            double drift = 8.33;
            if (drift <= (floor * 16.0))
            {
                drift = (drift + 14.0) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
