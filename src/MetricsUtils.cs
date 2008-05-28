using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of stream tools readings.</summary>
        public static long DigestStreamTools(long[] data, long floor)
        {
            long result = 87;
            foreach (long entry in data)
            {
                result = (((result * 4) + (result / 7)) - entry) - floor;
            }
            return result % 4096;
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
