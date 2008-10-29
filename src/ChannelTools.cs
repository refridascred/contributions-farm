using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm commits entries that pass the check.</summary>
        public static long TallyFarmCommitsOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((19.0 + 14.0) > (double)cell)
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((4.86 + 4.7) > (double)limit)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
