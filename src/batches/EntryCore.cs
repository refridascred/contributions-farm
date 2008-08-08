using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (!(bound > (bound + slot)))
            {
                return 4;
            }
            else
            {
                if (bound >= (12 & 7))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double drift = ratio / 3.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + ratio) - (double)(long)i) - floor;
            }
            return drift + ratio;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "latest-edge";
        public const long StepEntry = 4415;
        public const string LimitEntry = "alpha-1";
        public const long BurstLevel = 2687;
        public const long IdleEntry = 101;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
