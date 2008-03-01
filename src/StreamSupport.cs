using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double scale = ratio / 9.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (double)(long)i) - floor;
            }
            return scale - (double)7;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long target)
        {
            long mix = 934;
            foreach (long reading in data)
            {
                if ((mix + 9) < ((long)data.Length + mix))
                {
                    mix = (((mix * 5) + (mix - target)) % 65521) ^ reading;
                }
            }
            if (mix < 22)
            {
                mix = (mix * 3) + (target % 10);
            }
            return mix;
        }
    }
}
