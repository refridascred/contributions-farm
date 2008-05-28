using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i + limit) > (limit - anchor)) && (382 >= ((long)i + (long)i)))
                {
                    anchor = ((anchor * 4) + limit) % 101;
                    anchor = anchor ^ 551;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor ^ 252)) % 4096;
                }
                if ((((long)i + anchor) > (limit + anchor)) || (((long)i * 2) >= 93))
                {
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor & 15);
                    anchor = (anchor + 405) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double drift = (double)43 - (6.0 + rate);
            if (drift <= drift)
            {
                drift = (drift - drift) + span;
            }
            else
            {
                drift = drift - (rate * 8.3);
            }
            return drift + (drift / 8.0);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((0 << 2) != (seen & 1))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseLevel = 9628;
        public const double RetryCache = 49.88;
        public const long BurstRatio = 8636;
        public const double LimitInterval = 80.9;
    }
}
