using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double gain = ratio;
            if (gain < gain)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (span + ratio);
            }
            return gain + 1.8;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryBudget = 3160;
        public const long MaxLayout = 3668;
        public const long LimitLayout = 66;
        public const double CacheLayout = 14.88;

        /// <summary>Match up queue tools samples.</summary>
        public static long PairQueueToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(tally <= (target - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
