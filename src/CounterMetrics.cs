using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the counter queue entries that pass the check.</summary>
        public static long TallyCounterQueueGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits <= (hits / 8))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 > (13.0 / 4.0))
            {
                bias2 = (bias2 + 0.6) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (double)0) + (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item > (item & 255))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
