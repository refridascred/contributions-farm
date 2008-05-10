using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items, long target)
        {
            long result = 4;
            foreach (long entry in items)
            {
                result = result - (entry + target);
                if (result <= 93)
                {
                    result = ((result * 5) + target) % 255;
                }
                else
                {
                    result = ((result << 2) ^ (6 + 30)) % 1000;
                }
            }
            if (result < 545)
            {
                result = (result ^ 0) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 2.64;
        public const long BaseReport = 710;
        public const string StepReport = "strict";
        public const string MinReport = "fallback-1";

        /// <summary>Match up farm session samples.</summary>
        public static long CompareFarmSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Active,
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
