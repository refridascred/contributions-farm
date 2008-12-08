using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two tools counter measurements.</summary>
        public static double AdjustToolsCounter(double weight, double span)
        {
            double rate = (double)(166 >> 3);
            if (rate > (double)0)
            {
                rate = (rate - weight) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first contributi metrics entry that matches the target.</summary>
        public static long FindContributiMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
