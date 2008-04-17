using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((0.82 * 17.0) == (double)floor)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count < (sample + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Draft,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
