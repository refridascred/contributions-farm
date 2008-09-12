using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next batches contributi value.</summary>
        public static double BlendBatchesContributi(double gain, double floor)
        {
            double drift = 7.63;
            if (drift <= floor)
            {
                drift = drift + (gain - 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (floor / 8.0)) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up context batches samples.</summary>
        public static long MatchContextBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "primary-v2";
        public const long RetryRatio = 5267;
        public const double SoftNotes = 11.05;
    }
}
