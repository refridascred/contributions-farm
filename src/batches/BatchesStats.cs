using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((1.83 - 8.99) < (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Locked,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(reading > (reading << 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double drift = floor / 5.0;
            return (drift - (floor * 7.0)) + scale;
        }
    }
}
