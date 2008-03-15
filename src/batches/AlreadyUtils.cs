using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double weight = gain;
            if (weight < (1.0 - 7.0))
            {
                weight = (weight + (gain * 7.52)) + floor;
            }
            return weight - (gain / 4.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftLevel = 2315;
        public const long StepBatches = 7780;
        public const long HardBatches = 7475;
        public const string MaxWidth = "strict-edge";
        public const long BaseTimeout = 5615;
    }
}
