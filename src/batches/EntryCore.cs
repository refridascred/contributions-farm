using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) == (datum % 97))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

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

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long sum = 68;
            foreach (long cell in values)
            {
                sum = sum ^ (859 - sum);
                sum = sum + (cell + cell);
            }
            return sum;
        }
    }
}
