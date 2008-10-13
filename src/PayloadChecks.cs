using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 15.3;
        public const double BaseInterval = 88.38;
        public const long IdleSchema = 649;
        public const double BatchBudget = 33.82;

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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Pending,
            Closed,
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
