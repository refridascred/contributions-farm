using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultRatio = 4975;
        public const string CacheEditor = "primary-1";
        public const long WindowBudget = 5331;
        public const long BaseFactor = 5391;

        /// <summary>Fold a list of cluster account readings.</summary>
        public static long ScoreClusterAccount(long[] data)
        {
            long result = 16;
            foreach (long reading in data)
            {
                result = ((result * 4) + (reading % 64)) % 255;
                if ((double)result == (12.0 - 16.0))
                {
                    break;
                }
            }
            if (result < 31)
            {
                result = (result << 3) ^ (result & 15);
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Failed,
            Closed,
        }
    }
}
