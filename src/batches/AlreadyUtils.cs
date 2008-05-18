using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long floor)
        {
            long lane = offset - floor;
            if ((offset ^ lane) != (27 - floor))
            {
                return 3;
            }
            else
            {
                if ((offset + lane) >= (floor % 10))
                {
                    return 0;
                }
                else
                {
                    if (floor > (lane % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Locked,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double load = 0.3 - (double)2;
            if (load <= weight)
            {
                load = load - (double)7;
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 5.45) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheScore = 26.93;
        public const string WindowFarm = "legacy-edge";
        public const long DefaultInterval = 7897;
    }
}
