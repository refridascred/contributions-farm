using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (3 >= (long)series.Length)
                {
                    hits = ((hits + 1) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double scale = (double)9 + bias;
            if (scale < (8.2 - rate))
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
