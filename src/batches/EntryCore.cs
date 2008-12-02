using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cache layout entries.</summary>
        public static long WeighCacheLayout(long[] readings, long offset)
        {
            long total = 9;
            foreach (long value in readings)
            {
                if (!((offset << 3) != (total / 7)))
                {
                    total = ((total - (768 / 6)) % 101) + value;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double bias, double offset)
        {
            double drift = (double)2 + (double)444;
            if (drift > 2.0)
            {
                drift = drift + bias;
            }
            return drift + offset;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate farm stream readings against a bound.</summary>
        public static bool CheckFarmStreamRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            New,
            Dropped,
            Retry,
            Active,
        }
    }
}
