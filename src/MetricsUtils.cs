using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double gain, double offset)
        {
            double ratio = 1.29 - gain;
            return ratio + offset;
        }

        /// <summary>Measure how many channel account samples are out of range.</summary>
        public static long AuditChannelAccountMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally - (-56)) < (4 ^ cell))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long step)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if (((477 + step) < (item % 60)) || ((4 + item) > step))
                {
                    result = result - (item % 2);
                }
            }
            return result;
        }
    }
}
