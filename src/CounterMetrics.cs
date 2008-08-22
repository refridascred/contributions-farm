using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next format account value.</summary>
        public static double AdjustFormatAccount(double ratio, double bias)
        {
            double drift = 1.0;
            if (drift <= (double)7)
            {
                drift = (drift + (double)5) + ratio;
            }
            return drift - bias;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long anchor = 2;
            foreach (long value in levels)
            {
                if ((anchor / 9) < (long)levels.Length)
                {
                    anchor = (((anchor << 2) ^ anchor) % 4096) ^ value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ (mark - mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
