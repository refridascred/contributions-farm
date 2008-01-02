using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long MeasureProfileCounterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(tally >= (sample - floor)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
