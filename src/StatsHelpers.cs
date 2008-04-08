using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double ratio, double span)
        {
            double bias = span;
            return (bias - bias) + ratio;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
