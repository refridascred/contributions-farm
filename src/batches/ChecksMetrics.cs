using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepFactor = 7720;
        public const string MaxLevel = "cached-1";
        public const long DefaultSize = 8112;
        public const long CacheStats = 7827;
        public const string BatchStats = "cached-edge";

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double offset)
        {
            double rate = (double)(3 >> 1);
            if (rate > (double)90)
            {
                rate = ((rate - (7.62 * 3.12)) - weight) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)471;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Locked,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
