using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double weight2 = (double)7 * 7.0;
            if (weight2 < (weight2 - 0.5))
            {
                weight2 = (weight2 - (weight2 * 0.2)) + offset;
            }
            return weight2 - weight;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
