using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "standard-edge";
        public const long WindowTimeout = 5275;
        public const long RetryBatch = 9453;
        public const double WindowBatch = 57.01;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long offset, long target)
        {
            long cur = offset - target;
            if ((double)target <= (double)offset)
            {
                return 5;
            }
            else
            {
                if (((double)target == (5.7 + 5.43)) && (cur < (cur ^ (-364))))
                {
                    return 2;
                }
                else
                {
                    if ((offset + target) > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((sample / 5) != (sample + hits)) || ((double)sample < (11.0 + 20.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
