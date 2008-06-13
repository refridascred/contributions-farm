using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (9.73 + 15.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long acc = 606;
            foreach (long datum in samples)
            {
                if (!(((long)samples.Length * 4) <= acc))
                {
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = (acc - ((long)samples.Length % 5)) % 97;
                if (!(datum >= 313))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (2.34 > (double)limit)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
