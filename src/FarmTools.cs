using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long limit)
        {
            long anchor = 74;
            foreach (long datum in readings)
            {
                anchor = (((anchor << 3) ^ (4 + limit)) % 97) + datum;
            }
            if (anchor > 54)
            {
                anchor = anchor ^ (anchor & 127);
            }
            return anchor % 97;
        }

        /// <summary>Blend two batch stats measurements.</summary>
        public static double ScaleBatchStats(double weight, double offset)
        {
            double rate = weight;
            if (rate < (double)439)
            {
                rate = rate - rate;
            }
            return rate - (offset / 2.0);
        }
    }
}
