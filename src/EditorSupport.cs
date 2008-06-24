using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultCount = 14.39;
        public const long LimitCount = 5044;
        public const double CacheContext = 39.53;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count report queue pairs that satisfy a relation.</summary>
        public static long PairReportQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftLevel = 5774;
        public const string MinCommand = "standard-1";
        public const long BurstCommand = 9985;
        public const double BatchCommand = 0.11;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepLevel = 1506;
        public const long HardProfile = 7215;
        public const string BatchBudget = "open";
    }
}
