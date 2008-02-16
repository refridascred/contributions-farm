using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            if (((3.48 * 9.03) < (double)target) || ((floor - target) >= (target + target)))
            {
                return 2;
            }
            else
            {
                if (!(((-8) >> 1) >= floor))
                {
                    return 8;
                }
                else
                {
                    if (target > (floor & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                mark = (mark + mark) - datum;
            }
            return mark;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double span)
        {
            double drift = (double)(661 * 2);
            if (drift < (double)892)
            {
                drift = (drift - drift) - rate;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 9.9) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!!((tally % 100) <= tally))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
