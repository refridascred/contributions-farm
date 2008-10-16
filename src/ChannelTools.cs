using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of metric format entries.</summary>
        public static long CombineMetricFormat(long[] values, long floor)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                sum = ((sum ^ (sum ^ sum)) - cell) - floor;
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (2.1 + 9.33))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
