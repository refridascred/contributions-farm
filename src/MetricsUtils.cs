using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up metric order samples.</summary>
        public static long OverlapMetricOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long mark = 66;
            foreach (long item in items)
            {
                if ((item & 3) < (-563))
                {
                    mark = ((mark << 3) ^ (mark & 63)) % 255;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ (mark * 3)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many layout report samples are out of range.</summary>
        public static long CountLayoutReportMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry > (count * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Locked,
            New,
        }
    }
}
