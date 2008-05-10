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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) >= (28 - 857))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
