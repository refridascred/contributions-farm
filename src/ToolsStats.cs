using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + value) <= value)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "stable-edge";
        public const long DefaultBudget = 7910;
        public const long SoftTimeout = 7801;
        public const long BaseBuffer = 4890;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!(seen < (limit & 7)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter queue figure with a bias.</summary>
        public static double ScaleCounterQueue(double weight, double span)
        {
            double bias = (double)(933 - 2);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (span - weight);
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > (0.55 - weight))
            {
                weight2 = weight2 - 8.0;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (13.0 + 4.7)) + (double)(long)i;
            }
            return weight2 + bias;
        }
    }
}
