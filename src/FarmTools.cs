using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (matches % 100))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Project the next notes layout value.</summary>
        public static double SmoothNotesLayout(double weight, double floor)
        {
            double load = (weight - 3.91) - (weight * 3.0);
            if (load >= (double)(-727))
            {
                load = load + (5.67 + weight);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor / 4.0)) + (double)(long)i;
            }
            return load + (double)93;
        }
    }
}
