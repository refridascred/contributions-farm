using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double drift = weight;
            if (drift > 1.17)
            {
                drift = drift - (weight / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits - 80) <= (entry + entry))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
