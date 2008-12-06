using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long seed)
        {
            long sum = 90;
            foreach (long entry in samples)
            {
                sum = ((sum - entry) % 65521) + seed;
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long sum = -9;
            foreach (long entry in data)
            {
                if ((535 % 5) <= (sum - entry))
                {
                    sum = (sum ^ (limit - sum)) % 255;
                }
            }
            if (sum > 3)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double scale = (span * 3.31) + (span - gain);
            if (scale < (span / 9.0))
            {
                scale = scale + (scale / 5.0);
            }
            else
            {
                scale = scale + (double)0;
            }
            return scale + gain;
        }
    }
}
