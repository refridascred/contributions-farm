using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long floor, long step)
        {
            if ((double)step <= (11.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if (21 < step)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a contributi report figure with a bias.</summary>
        public static double ProjectContributiReport(double rate, double span)
        {
            double bias = rate * 17.0;
            if (bias <= (double)4)
            {
                bias = bias + rate;
            }
            return bias - (rate + span);
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            Retry,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data, long seed)
        {
            long carry = 609;
            foreach (long sample in data)
            {
                carry = ((carry * 4) + (sample + sample)) + seed;
            }
            return carry;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double weight = gain;
            if (weight <= (double)445)
            {
                weight = weight + (8.22 / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight + (span - gain);
        }
    }
}
