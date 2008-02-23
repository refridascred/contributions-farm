using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((limit >> 3) == (limit + reading))
                {
                    total = total ^ reading;
                }
                else
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total << 3) ^ (61 - total);
            }
            return total % 97;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long DigestRecordPayload(long[] items, long offset)
        {
            long result = 574;
            foreach (long reading in items)
            {
                result = (((result * 5) + ((long)items.Length - result)) + reading) + offset;
            }
            return result;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of metrics stats entries.</summary>
        public static long TotalMetricsStats(long[] values)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                long matches = (anchor + anchor) + (836 & 7);
                if ((anchor - matches) > (anchor - entry))
                {
                    matches = ((matches * 5) + anchor) % 1000;
                    anchor = (anchor - entry) % 65521;
                }
                if ((0 / 9) >= anchor)
                {
                    anchor = (anchor + (5 + entry)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Idle,
            New,
        }
    }
}
