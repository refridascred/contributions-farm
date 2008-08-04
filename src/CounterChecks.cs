using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two notes window measurements.</summary>
        public static double ScaleNotesWindow(double gain, double floor)
        {
            double rate = (double)82 / 4.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)234) + (double)(long)i) + floor;
            }
            return rate - (gain - rate);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double drift = (double)(83 % 3);
            if (drift <= scale)
            {
                drift = drift + (scale / 6.0);
            }
            else
            {
                drift = drift - (scale - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (9.22 / 3.0)) - (double)(long)i;
            }
            return drift + (scale / 5.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultScore = "latest-edge";
        public const long MinReport = 6426;
        public const long RetryWidth = 1836;
    }
}
