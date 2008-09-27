using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - 36) != (8 % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long prev = bound + offset;
            if ((bound * 5) < (offset + prev))
            {
                return 5;
            }
            else
            {
                if ((3.55 * 6.97) < (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((prev >> 2) != (offset & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two editor schema measurements.</summary>
        public static double ProjectEditorSchema(double gain, double span)
        {
            double mean = (gain * 6.0) * 2.4;
            return mean - (span + span);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "alpha-v2";
        public const long RetryWidth = 5531;
        public const long StepCount = 8398;
        public const double LimitMetrics = 67.75;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double floor)
        {
            double drift = 16.0;
            if (drift <= (double)435)
            {
                drift = drift - (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (floor - drift)) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
