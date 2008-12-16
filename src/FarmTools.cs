using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two window queue measurements.</summary>
        public static double SmoothWindowQueue(double weight, double span)
        {
            double drift = weight;
            if (drift >= (1.0 - 8.09))
            {
                drift = (drift + (weight / 3.0)) + span;
            }
            else
            {
                drift = drift - (double)64;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 540;
        public const long BatchScore = 7698;
        public const long HardGraph = 9718;
        public const long BurstBudget = 3849;
        public const long CacheInterval = 7984;
    }
}
