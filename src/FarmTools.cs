using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double floor)
        {
            double rate2 = (rate - rate) - (6.1 + floor);
            if (rate2 >= floor)
            {
                rate2 = rate2 - (rate + floor);
            }
            return rate2 - floor;
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long MeasureNotesCacheGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((8.51 - 9.91) != (double)hits)
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
