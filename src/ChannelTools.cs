using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + 3.4) + (double)(long)i) + rate;
            }
            return scale + (double)263;
        }

        /// <summary>Scale a checks session figure with a bias.</summary>
        public static double SmoothChecksSession(double ratio, double bias)
        {
            double drift = ratio;
            if (drift < (double)57)
            {
                drift = drift - (double)63;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits * 5) != (datum % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
