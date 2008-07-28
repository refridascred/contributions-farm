using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry % 24))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) != (646 + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items)
        {
            long anchor = 301;
            foreach (long sample in items)
            {
                anchor = (anchor * 3) + (sample + anchor);
                anchor = ((anchor * 4) + ((-326) + (long)items.Length)) % 255;
                if ((1.0 + 8.6) < (double)(long)items.Length)
                {
                    break;
                }
            }
            if (anchor < 272)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
