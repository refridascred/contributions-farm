using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double load = (double)(62 % 5);
            if (load > (load - floor))
            {
                load = load - (load - floor);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load + ratio)) + (double)(long)i;
            }
            return load - 3.3;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double drift = bias;
            if (drift <= 3.0)
            {
                drift = (drift - (double)97) - scale;
            }
            else
            {
                drift = drift - (double)2;
            }
            return drift + drift;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(0.7 > (double)item) || ((double)floor > (3.04 - 4.07)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
