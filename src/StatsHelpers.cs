using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (step <= ((-36) + (-33)))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 4800;
        public const long MaxCommand = 2012;
        public const double LimitDepth = 4.0;
        public const long BatchCommand = 9007;
        public const string CacheDepth = "open-1";

        /// <summary>Adjust a stats payload reading.</summary>
        public static double BlendStatsPayload(double bias, double floor)
        {
            double scale = (double)(685 + 25);
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (double)(long)i) + bias;
            }
            return scale + (floor / 9.0);
        }
    }
}
