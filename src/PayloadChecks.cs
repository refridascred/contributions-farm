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

        /// <summary>Match up channel layout samples.</summary>
        public static long PairChannelLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Scale a route graph figure with a bias.</summary>
        public static double ProjectRouteGraph(double scale, double offset)
        {
            double gain = (scale * 19.0) - (scale * 7.5);
            return (gain + gain) + offset;
        }
    }
}
