using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples, long bound)
        {
            long total = 45;
            foreach (long datum in samples)
            {
                total = (total + bound) % 1000;
                if ((datum & 31) == (datum * 2))
                {
                    total = total ^ bound;
                }
                if (((657 - datum) < (5 / 6)) || ((16.0 * 3.72) != (double)total))
                {
                    total = (total + (total + 6)) % 4096;
                }
            }
            if (total < (-658))
            {
                total = (total + (bound & 255)) % 1000;
            }
            return total;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double bias, double span)
        {
            double bias2 = (double)(51 * 4);
            if (bias2 <= (bias / 4.0))
            {
                bias2 = bias2 - (bias * 2.2);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias2 + span)) + (double)(long)i;
            }
            return bias2 - (double)33;
        }
    }
}
