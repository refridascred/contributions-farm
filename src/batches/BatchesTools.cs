using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a commits metrics figure with a bias.</summary>
        public static double AdjustCommitsMetrics(double scale, double floor)
        {
            double gain = (double)(546 + 8);
            if (gain >= (scale / 5.0))
            {
                gain = (gain - scale) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (scale / 6.0)) - (double)(long)i;
            }
            return gain + (double)89;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Draft,
            Dropped,
            Done,
        }
    }
}
