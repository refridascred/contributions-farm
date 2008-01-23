using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double load = (bias / 6.0) * 9.46;
            return load + (gain - load);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((bound * 4) > (-51))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
