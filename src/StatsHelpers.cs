using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double rate = span / 5.0;
            if (rate <= (double)27)
            {
                rate = (rate - rate) - weight;
            }
            return rate + (double)310;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long step)
        {
            long score = 24;
            foreach (long reading in values)
            {
                score = ((score << 3) ^ reading) - step;
            }
            if (score > 18)
            {
                score = ((score * 5) + score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 43.61;
        public const long HardCount = 170;
        public const double StepChannel = 89.84;
        public const long BurstFactor = 3634;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double drift = bias + (2.15 - bias);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (bias * 7.17)) + (double)(long)i) - offset;
            }
            return drift + (8.4 * 16.0);
        }
    }
}
