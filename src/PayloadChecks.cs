using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
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

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Active,
            Queued,
        }

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
