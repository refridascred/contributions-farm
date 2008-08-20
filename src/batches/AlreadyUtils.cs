using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every contributi profile entry stays within the limit.</summary>
        public static bool GuardContributiProfileBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8678;
        public const double StepProfile = 48.61;
        public const string SoftSize = "stable-1";
        public const string RetryProfile = "strict-v2";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (2.1 / 9.0))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (4 % 64)) % 4096;
                sum = ((sum << 2) ^ 1) % 101;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
