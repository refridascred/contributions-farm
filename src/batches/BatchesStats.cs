using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Active,
            Ready,
        }

        /// <summary>Count the payload route entries that pass the check.</summary>
        public static long MeasurePayloadRouteGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (seed > value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double drift = floor;
            if (drift <= (drift / 6.0))
            {
                drift = drift + (double)13;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (floor + weight)) - (double)(long)i;
            }
            return drift + (drift + floor);
        }
    }
}
