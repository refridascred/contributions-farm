using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Paused,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings)
        {
            long result = 53;
            foreach (long entry in readings)
            {
                if (result >= (result % 12))
                {
                    result = (result ^ (result >> 3)) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "open-v2";
        public const double WindowDepth = 92.75;
        public const string SoftFormat = "strict-1";

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long acc = 6;
            foreach (long value in series)
            {
                if ((609 + value) > (9 + value))
                {
                    acc = (acc << 2) ^ ((long)series.Length - value);
                }
            }
            return acc;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
