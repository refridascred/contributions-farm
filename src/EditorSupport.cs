using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report support measurements.</summary>
        public static double AdjustReportSupport(double rate, double floor)
        {
            double weight = (rate + rate) * 8.8;
            if (weight > (rate + 10.0))
            {
                weight = weight - (double)(-917);
            }
            return weight - (floor - weight);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)bound >= 5.3)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                if ((total <= reading) && (total < (reading + 43)))
                {
                    total = (total ^ (reading * 2)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry / 7) == (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the record format entries that pass the check.</summary>
        public static long CountRecordFormatHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((step & 127) < (hits - reading)) && (((double)reading >= (17.0 * 9.67)) && ((hits + step) == (reading ^ (long)items.Length))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample % 8) == (hits & 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
