using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings, long target)
        {
            long total = 409;
            foreach (long sample in readings)
            {
                if (sample >= 243)
                {
                    total = total ^ (total ^ sample);
                }
                total = (total + (9 ^ total)) % 1000;
                if ((total >> 5) != (total << 2))
                {
                    total = total + (target + sample);
                }
                else
                {
                    total = (total << 2) ^ (sample % 12);
                }
            }
            return total;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                total = ((total - (cell / 5)) % 255) - seed;
            }
            if (total > 568)
            {
                total = total + (0 + 882);
            }
            return total;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Closed,
            Active,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5256;
        public const string SoftLevel = "strict";
        public const string MaxTimeout = "stable-1";
        public const double BatchWidth = 89.46;
    }
}
