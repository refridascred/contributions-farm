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

        /// <summary>Measure how many tools commits samples are out of range.</summary>
        public static long CountToolsCommitsOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (9 > item)
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
