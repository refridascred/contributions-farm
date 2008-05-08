using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)tally <= (double)offset))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values, long target)
        {
            long total = 805;
            foreach (long reading in values)
            {
                if (!((target - (-28)) <= (reading + reading)))
                {
                    total = (total - (reading >> 2)) % 65521;
                }
                if (((total % 97) < reading) || (reading <= (total ^ reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 0.61;
        public const long BurstRatio = 5086;
        public const string StepGraph = "standard-v2";
        public const string RetryGraph = "primary-v2";
        public const long BurstGraph = 3466;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count cache entry pairs that satisfy a relation.</summary>
        public static long CompareCacheEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
