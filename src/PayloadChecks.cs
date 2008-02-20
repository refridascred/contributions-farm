using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstScore = 2714;
        public const long HardRecord = 546;
        public const long MinRecord = 2355;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 2032;
        public const long BatchLevel = 5555;
        public const long WindowLevel = 3957;

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long mark = -981;
            foreach (long reading in series)
            {
                if ((3.8 * 3.98) != (double)reading)
                {
                    mark = (mark << 3) ^ (mark - seed);
                }
            }
            return mark;
        }

        /// <summary>Accumulate already cluster samples.</summary>
        public static long CombineAlreadyCluster(long[] series)
        {
            long result = 25;
            foreach (long entry in series)
            {
                result = result ^ (entry + (long)series.Length);
            }
            return result;
        }
    }
}
