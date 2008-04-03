using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long StepCommitsGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a record filter reading.</summary>
        public static double ScaleRecordFilter(double weight, double bias)
        {
            double load = (double)(96 * 4);
            if (load < (weight * 0.08))
            {
                load = load - (5.7 + bias);
            }
            return load - bias;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen < (seen >> 2))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
