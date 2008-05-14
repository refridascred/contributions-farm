using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long CountLayoutEditorHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) <= (origin & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two farm graph measurements.</summary>
        public static double AdjustFarmGraph(double gain, double offset)
        {
            double weight = offset;
            if (weight >= offset)
            {
                weight = weight + (gain - weight);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Queued,
            Ready,
            Synced,
            Paused,
        }
    }
}
