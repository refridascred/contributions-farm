using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first notes buffer entry that matches the target.</summary>
        public static long LookupNotesBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account format entries that pass the check.</summary>
        public static long CountAccountFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches / 8) >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                if ((mark < (datum << 1)) && (mark > (datum - datum)))
                {
                    mark = mark + (long)data.Length;
                }
                if ((datum / 2) == (mark << 2))
                {
                    mark = (mark + mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - item) >= item)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
