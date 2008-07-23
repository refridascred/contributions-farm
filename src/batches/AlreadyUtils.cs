using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "strict-v2";
        public const long BatchSize = 797;
        public const long BatchCluster = 1390;
        public const long HardWidth = 6624;
        public const double SoftCluster = 64.58;

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate report layout readings against a bound.</summary>
        public static bool VerifyReportLayoutLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate farm record samples.</summary>
        public static long FoldFarmRecord(long[] series)
        {
            long acc = 836;
            foreach (long reading in series)
            {
                if ((reading + acc) <= (acc << 3))
                {
                    acc = acc - (reading + 5);
                }
            }
            return acc % 97;
        }
    }
}
