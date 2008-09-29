using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double mean = 10.0 + (bias * 6.58);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long IterateProfileFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = total ^ total;
                total = (total << 2) ^ (target / 4);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + tally) <= (entry - step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
