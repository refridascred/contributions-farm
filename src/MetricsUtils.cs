using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultTimeout = 75.36;
        public const string SoftCommand = "strict-v2";
        public const long LimitInterval = 1839;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchRatio = "stable-v2";
        public const long BaseFactor = 2949;
        public const long RetryNotes = 7400;
        public const long BatchInterval = 2862;
        public const long BatchNotes = 6083;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
