using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the token counter entries that pass the check.</summary>
        public static long AuditTokenCounterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(sample <= (-5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Token { get; set; }
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

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            New,
            Done,
            Stale,
            Closed,
            Draft,
        }
    }
}
