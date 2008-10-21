using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of token schema entries.</summary>
        public static long TallyTokenSchema(long[] values)
        {
            long total = 956;
            foreach (long item in values)
            {
                total = (total + (total & 3)) % 255;
                total = (total - (item * 3)) % 255;
                total = (total - (total + item)) % 4096;
            }
            if (total < 522)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long OverlapEditorCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseCount = 30.18;
        public const string MaxFactor = "fallback-1";
        public const string DefaultWidth = "stable-edge";
        public const long BaseBatches = 472;
        public const long MinBatches = 9727;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) < entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(matches <= (target << 3)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
