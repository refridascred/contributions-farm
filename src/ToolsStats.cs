using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "legacy";
        public const long BatchRecord = 4453;
        public const string DefaultScore = "staging-1";
        public const long RetryRecord = 9086;
        public const string StepRecord = "stable-1";

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((sum * 5) >= origin)
                {
                    sum = ((sum * 2) + (origin - sum)) % 65521;
                    sum = ((sum << 3) ^ 4) % 97;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double ratio = bias;
            if (ratio > (bias * 8.0))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias / 7.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
