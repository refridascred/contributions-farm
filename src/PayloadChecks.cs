using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double bias)
        {
            double scale2 = bias;
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (scale2 * 3.8)) - (double)(long)i;
            }
            return scale2 - (scale / 8.0);
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long TallyBufferEditorGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)8 <= (double)count)
                {
                    count = ((count + 3) ^ item) - limit;
                }
            }
            return count;
        }
    }
}
