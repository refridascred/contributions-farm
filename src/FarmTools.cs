using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a context commits reading.</summary>
        public static double AdjustContextCommits(double bias, double bias2)
        {
            double load = bias;
            if (load <= (double)94)
            {
                load = (load - (double)78) + bias2;
            }
            return load + load;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token checks entries that pass the check.</summary>
        public static long CountTokenChecksHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((sample - sample) <= seen) && ((double)sample >= 10.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
