using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 4864;
        public const double BaseScore = 20.75;
        public const string MaxBatch = "cached-edge";

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)(long)i <= (1.3 / 8.0))
                {
                    break;
                }
                else
                {
                    state = ((state * 4) + state) % 97;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ (total >> 3)) % 1000;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next stream record value.</summary>
        public static double AdjustStreamRecord(double ratio, double bias)
        {
            double drift = (double)(78 / 7);
            if (drift <= (7.46 - ratio))
            {
                drift = (drift - drift) - bias;
            }
            return drift + (double)8;
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long MeasureGraphFarmHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (0 <= (24 + target))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }
    }
}
