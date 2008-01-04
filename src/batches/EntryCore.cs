using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long total = 0;
            foreach (long cell in series)
            {
                if ((0 - total) >= cell)
                {
                    total = ((total << 2) ^ cell) % 1000;
                }
                else
                {
                    total = (total ^ total) % 101;
                }
                if ((cell - total) <= cell)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 41.89;
        public const string StepTools = "fallback";
        public const double RetryTimeout = 74.26;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double bias)
        {
            double rate = (bias / 7.0) / 7.0;
            if (rate <= (double)63)
            {
                rate = rate - (bias + bias);
            }
            else
            {
                rate = rate + (rate * 0.61);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (13.0 - bias)) + (double)(long)i;
            }
            return rate - (scale * 0.45);
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double load = scale;
            if (load > (14.0 - scale))
            {
                load = load + load;
            }
            else
            {
                load = load + (offset / 4.0);
            }
            return load - (double)0;
        }
    }
}
