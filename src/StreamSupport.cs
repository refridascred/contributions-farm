using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double weight, double bias)
        {
            double gain = (weight + bias) * 3.1;
            if (gain >= 1.06)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain + gain)) - (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double floor)
        {
            double load = (double)(104 / 6);
            if (load <= floor)
            {
                load = (load + 19.0) - ratio;
            }
            else
            {
                load = load + (double)(-286);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (5.6 + 9.0)) - (double)(long)i;
            }
            return load - (floor / 9.0);
        }

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long MeasureQueueWindowOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((6 ^ offset) < datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
