using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double mean = (weight * 8.35) * 7.6;
            if (mean <= (span + weight))
            {
                mean = mean + (span / 6.0);
            }
            return mean + weight;
        }

        /// <summary>Roll a cache tools counter forward.</summary>
        public static long StepCacheTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 3) + (876 + limit);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = state - (long)i;
                state = (state + (state * 3)) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
