using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)target)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double scale = floor;
            if (scale <= (double)37)
            {
                scale = scale - (11.0 - 3.19);
            }
            return scale - rate;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
