using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftBudget = "latest-edge";
        public const long LimitSpan = 1214;
        public const string WindowStats = "primary";

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleCount = "primary-edge";
        public const long BaseInterval = 6249;
        public const long BurstFactor = 370;
        public const long BurstSupport = 1011;
        public const long BatchSupport = 2545;

        /// <summary>Grade a batches record value against two limits.</summary>
        public static long ClassifyBatchesRecord(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if ((62 * 4) > (floor - 9))
            {
                return 8;
            }
            else
            {
                if (delta > (delta % 97))
                {
                    return 5;
                }
                else
                {
                    if (34 >= (floor2 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
