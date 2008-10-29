using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((offset ^ seen) == (23 ^ offset))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
