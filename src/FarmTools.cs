using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double drift = bias;
            if (drift > (double)3)
            {
                drift = (drift + (bias / 5.0)) + offset;
            }
            else
            {
                drift = drift + (double)847;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (anchor - floor)) + sample;
            }
            return anchor;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
