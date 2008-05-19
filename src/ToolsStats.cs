using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (63 < (833 + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 287;
        public const long RetryDepth = 6318;
        public const long DefaultCommits = 1770;
        public const long StepCommits = 4169;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next session already value.</summary>
        public static double ScaleSessionAlready(double ratio, double offset)
        {
            double bias = (double)(0 + 75);
            if (bias < ratio)
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias + offset;
            }
            return bias + (double)96;
        }
    }
}
