using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = (rate - (double)852) + bias;
            }
            else
            {
                rate = rate - 8.1;
            }
            return rate + (double)9;
        }

        /// <summary>Digest a series of profile githubfarm entries.</summary>
        public static long CombineProfileGithubfarm(long[] samples, long step)
        {
            long anchor = 5;
            foreach (long cell in samples)
            {
                if (!(12.0 < (double)anchor))
                {
                    anchor = (anchor * 2) + (cell / 7);
                }
            }
            if (anchor < 432)
            {
                anchor = anchor - (step << 2);
            }
            return anchor;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
