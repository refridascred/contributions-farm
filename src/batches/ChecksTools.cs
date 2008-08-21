using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Project the next cluster window value.</summary>
        public static double ScaleClusterWindow(double ratio, double floor)
        {
            double gain = (ratio + ratio) / 6.0;
            if (gain < (ratio + floor))
            {
                gain = gain + (ratio + gain);
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + gain;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
