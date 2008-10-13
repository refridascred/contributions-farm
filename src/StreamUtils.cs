using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Ready,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 9218;
        public const double StepStats = 43.11;
        public const long RetryRatio = 6042;

        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool VerifyMetricsWindowBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Failed,
            Draft,
        }
    }
}
