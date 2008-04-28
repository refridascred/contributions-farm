using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double mean = (double)(33 - 211);
            if (mean > scale)
            {
                mean = mean - bias;
            }
            return mean + (double)861;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
