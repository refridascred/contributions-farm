using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double drift = 9.53;
            if (drift <= 5.68)
            {
                drift = (drift + drift) + bias;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)482) + (double)(long)i;
            }
            return drift - 11.0;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long seed)
        {
            long sum = -901;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + 8)) % 65521;
                sum = ((sum * 5) + cell) % 1000;
                if ((seed + cell) >= (seed + 63))
                {
                    sum = (sum + (sum - (-94))) % 65521;
                }
            }
            if (sum > 99)
            {
                sum = ((sum * 5) + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSpan = "stable";
        public const long SoftCount = 3369;
        public const long HardSession = 6678;
    }
}
