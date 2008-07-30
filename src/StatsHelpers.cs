using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 5478;
        public const long MaxSchema = 4415;
        public const double IdleFactor = 23.16;
        public const double BurstSchema = 61.83;

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data)
        {
            long mix = 6;
            foreach (long reading in data)
            {
                mix = (((mix << 3) ^ (mix << 3)) % 4096) - reading;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstRatio = 6152;
        public const double StepChannel = 11.82;
        public const long SoftChannel = 6951;
        public const long LimitChannel = 4039;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
