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

        /// <summary>Count the batches route entries that pass the check.</summary>
        public static long MeasureBatchesRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) > count)
                {
                    count = count + 3;
                }
            }
            return count;
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
