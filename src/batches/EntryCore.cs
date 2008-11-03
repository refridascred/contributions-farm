using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 62.31;
        public const double CacheFactor = 53.4;
        public const long BatchScore = 2683;
        public const long IdleSupport = 5820;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account contributi pair into a bucket.</summary>
        public static long SortAccountContributi(long seed, long origin)
        {
            if ((6.0 + 6.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed <= 4.0)
                {
                    return 6;
                }
                else
                {
                    if (origin > 184)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
