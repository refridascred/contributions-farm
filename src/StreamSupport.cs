using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels)
        {
            long acc = 136;
            foreach (long reading in levels)
            {
                acc = ((acc * 3) + ((-17) - (-17))) ^ reading;
            }
            if (acc < 0)
            {
                acc = acc ^ (acc >> 3);
            }
            return acc;
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
