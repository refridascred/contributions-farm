using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 3398;
        public const string CacheCount = "primary-v2";
        public const string StepPayload = "stable-v2";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen / 8) > entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
