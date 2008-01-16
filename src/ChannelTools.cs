using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double weight = floor * 9.0;
            if (weight > (ratio / 9.0))
            {
                weight = weight + (double)0;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (ratio + floor)) - (double)(long)i;
            }
            return weight + (4.0 * 3.4);
        }

        /// <summary>Rank contributi notes input into a small class.</summary>
        public static long GradeContributiNotes(long bound, long floor)
        {
            long lane = bound + floor;
            if ((bound ^ lane) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)lane != (double)4)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
