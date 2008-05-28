using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 3105;
        public const long SoftSize = 3095;
        public const long BatchBudget = 7289;
        public const long DefaultFactor = 3521;
        public const string IdleWidth = "stable";

        /// <summary>Grade a batches editor value against two limits.</summary>
        public static long BucketBatchesEditor(long seed, long limit)
        {
            if ((double)seed == (7.0 * 5.7))
            {
                return 2;
            }
            else
            {
                if ((limit - 62) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed & 15) < (seed << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
