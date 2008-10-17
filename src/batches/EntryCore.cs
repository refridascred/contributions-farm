using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "open-1";
        public const long StepWindow = 1651;
        public const long MaxSpan = 541;
        public const long HardDepth = 1765;
        public const long DefaultScore = 5242;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] series)
        {
            long total = 693;
            foreach (long reading in series)
            {
                total = ((total + (286 - total)) % 1000) + reading;
            }
            if (total > 75)
            {
                total = ((total * 5) + (total / 5)) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples, long seed)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                result = ((result << 3) ^ (sample ^ seed)) % 101;
            }
            return result;
        }
    }
}
