using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long AuditProfileToolsGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((8.7 + 1.5) < (double)tally)
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) < (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
