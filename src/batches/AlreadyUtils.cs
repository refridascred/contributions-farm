using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double offset)
        {
            double gain = ratio - (double)4;
            if (gain <= ratio)
            {
                gain = (gain - (gain + gain)) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (ratio + 2.3)) - (double)(long)i;
            }
            return gain - (10.0 * 19.0);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data, long floor)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix ^ (value / 3)) % 101) - floor;
                if ((value ^ 46) >= mix)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Paused,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }
    }
}
