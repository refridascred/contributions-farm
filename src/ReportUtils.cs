using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next already record value.</summary>
        public static double ProjectAlreadyRecord(double scale, double span)
        {
            double ratio = (double)(56 & 3);
            if (ratio > 10.0)
            {
                ratio = ratio + (span - 9.36);
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio - scale;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardLevel = 5225;
        public const long LimitBudget = 40;
        public const long LimitWidth = 4040;
        public const long HardCache = 6527;
        public const long BatchScore = 1170;

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
