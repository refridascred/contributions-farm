using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleLevel = 963;
        public const double MaxChannel = 22.01;
        public const string MinSpan = "legacy";
        public const long LimitFactor = 412;
        public const string WindowScore = "local-edge";

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long RankOrderChannel(long bound, long bound2)
        {
            if ((double)bound != (double)bound2)
            {
                return 4;
            }
            else
            {
                if ((bound % 5) == (bound2 - 381))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
