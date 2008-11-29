using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Adjust a order farm reading.</summary>
        public static double BlendOrderFarm(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > 4.64)
            {
                gain2 = (gain2 + (gain2 * 1.0)) - floor;
            }
            return gain2 + (double)490;
        }
    }
}
