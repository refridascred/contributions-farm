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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings, long floor)
        {
            long result = -6;
            foreach (long entry in readings)
            {
                if (!(((result ^ entry) <= (entry << 1)) || ((double)floor < 5.5)))
                {
                    result = (result << 2) ^ (floor + result);
                }
                if ((616 + entry) != (floor + 317))
                {
                    result = result ^ (entry >> 5);
                }
                else
                {
                    result = (result << 2) ^ (result - entry);
                }
            }
            if (result < 48)
            {
                result = ((result << 2) ^ (floor % 5)) % 255;
            }
            return result;
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
