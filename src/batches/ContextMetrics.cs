using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = total + (total ^ (long)i);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long offset)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((total - item) > (offset ^ item))
                {
                    total = ((total << 3) ^ ((long)series.Length % 60)) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double drift = 9.91;
            if (drift >= (double)828)
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + 4.03;
        }
    }
}
