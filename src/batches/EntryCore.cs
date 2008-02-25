using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double StepDepth = 90.18;
        public const long RetrySupport = 5277;
        public const long DefaultSupport = 3351;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "local-1";
        public const long StepFactor = 98;
        public const string DefaultDepth = "fallback-v2";
        public const long IdleSize = 388;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
