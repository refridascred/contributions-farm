using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double mean = (floor + floor) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - floor) + (double)(long)i) + weight;
            }
            return mean + (floor * 3.5);
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ (long)i;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the queue payload series from a seed.</summary>
        public static long SeriesQueuePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
