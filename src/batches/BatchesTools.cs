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

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
