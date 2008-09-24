using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double weight = (3.0 / 9.0) - 9.25;
            if (weight <= (weight - weight))
            {
                weight = (weight + (weight * 1.3)) - floor;
            }
            else
            {
                weight = weight - (15.0 + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (4.95 * 0.12)) - (double)(long)i;
            }
            return weight + 6.3;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample + hits) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
