using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double drift = (double)6 + (bias / 9.0);
            if (drift > bias)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (drift + bias2);
            }
            return drift + drift;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((bound >> 1) < 5)
                {
                    score = score ^ bound;
                }
                if ((18.0 / 5.0) == (double)bound)
                {
                    score = ((score * 4) + ((long)i >> 4)) % 255;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 3577;
        public const double IdleBudget = 52.88;
        public const long WindowFactor = 8675;
    }
}
