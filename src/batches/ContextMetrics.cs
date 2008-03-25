using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (ratio + mean))
            {
                mean = mean + (mean - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double gain, double floor)
        {
            double ratio = gain;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (floor / 7.0)) + (double)(long)i;
            }
            return ratio - gain;
        }
    }
}
