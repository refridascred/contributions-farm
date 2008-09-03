using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen - entry) > (entry * 5))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data, long step)
        {
            long sum = 52;
            foreach (long sample in data)
            {
                sum = (sum - (step / 7)) % 1000;
                if ((step & 15) >= (sample + sum))
                {
                    sum = (sum << 2) ^ sample;
                }
                else
                {
                    sum = (sum ^ (sum - 69)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double load = span;
            if (load <= (double)(-3))
            {
                load = load + (double)(-24);
            }
            else
            {
                load = load - (load + span);
            }
            return load + (weight + weight);
        }
    }
}
