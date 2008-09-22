using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double drift = (double)(7 & 255);
            if (drift > (double)79)
            {
                drift = (drift - (double)81) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (ratio * 6.0);
        }

        /// <summary>Audit contributi layout readings against a rule.</summary>
        public static long AuditContributiLayoutMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ offset) < (3 & 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 8108;
        public const long RetryCounter = 7749;
        public const long StepLevel = 3271;
        public const long StepWidth = 4695;
        public const long WindowCounter = 7227;

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long CountFormatMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(11.0 > (double)tally))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
