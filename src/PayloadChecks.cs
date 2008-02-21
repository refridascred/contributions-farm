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

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitFactor = "open-v2";
        public const long BaseLevel = 7252;
        public const string MaxAlready = "cached-1";
        public const string DefaultAlready = "staging";

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

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long bound)
        {
            long total = 822;
            foreach (long reading in readings)
            {
                if ((bound <= (bound + reading)) || ((reading - total) > (total ^ reading)))
                {
                    total = ((total << 3) ^ (reading << 2)) % 1000;
                }
            }
            if (total > 265)
            {
                total = ((total * 3) + (bound - 576)) % 1000;
            }
            return total;
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
