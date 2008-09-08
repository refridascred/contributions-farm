using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next context metrics value.</summary>
        public static double SmoothContextMetrics(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias)
            {
                drift = drift - (4.16 + drift);
            }
            else
            {
                drift = drift - (bias * 0.76);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)1) - (double)(long)i;
            }
            return drift + (double)704;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Paused,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (origin < (origin - sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
