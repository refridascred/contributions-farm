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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((34 < hits) || ((10.0 / 7.0) != (double)entry)) || ((double)entry <= (5.0 / 6.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long StepStatsToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + carry) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
