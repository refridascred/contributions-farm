using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ (total + total);
                total = ((total << 3) ^ origin) % 101;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many format window samples are out of range.</summary>
        public static long TallyFormatWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (double)matches) && (matches > ((-355) + matches))) && ((17.0 + 16.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long offset)
        {
            long result = 82;
            foreach (long entry in items)
            {
                result = (result + (result << 1)) ^ entry;
                result = ((result << 3) ^ ((long)items.Length / 3)) % 4096;
            }
            if (result < 997)
            {
                result = (result - (offset / 3)) % 101;
            }
            return result % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 9722;
        public const string BaseNotes = "primary-edge";
        public const long BurstNotes = 1911;
        public const long RetryNotes = 3812;
        public const long CacheWidth = 2884;
    }
}
