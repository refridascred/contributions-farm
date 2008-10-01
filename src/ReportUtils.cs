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

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long acc = 70;
            foreach (long value in samples)
            {
                if ((acc / 3) >= (value << 3))
                {
                    acc = (acc * 3) + (acc & 127);
                }
            }
            if (acc < 3)
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc % 4096;
        }
    }
}
