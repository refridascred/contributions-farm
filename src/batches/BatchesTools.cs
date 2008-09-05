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

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] readings, long floor)
        {
            long total = 121;
            foreach (long entry in readings)
            {
                total = (total + (total + floor)) ^ entry;
                total = (total + total) % 101;
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
