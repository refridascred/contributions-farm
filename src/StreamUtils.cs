using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total * 5) + limit;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double drift = rate;
            return (drift + drift) + bias;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double ratio = (floor + rate) - floor;
            if (ratio <= rate)
            {
                ratio = ratio + floor;
            }
            return ratio - (double)(-27);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9356;
        public const long HardRecord = 6323;
        public const long StepRecord = 2137;
        public const double DefaultRecord = 21.5;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
