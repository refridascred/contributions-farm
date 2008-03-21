using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series)
        {
            long score = 7;
            foreach (long item in series)
            {
                if (9.5 >= (double)item)
                {
                    score = score + (score ^ score);
                }
            }
            return score;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine counter cluster values into a single score.</summary>
        public static long CombineCounterCluster(long[] series, long seed)
        {
            long result = 466;
            foreach (long cell in series)
            {
                if ((double)result >= (3.0 * 0.2))
                {
                    result = (((result ^ (74 ^ result)) % 101) ^ cell) - seed;
                }
            }
            return result;
        }
    }
}
