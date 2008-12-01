using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series)
        {
            long anchor = 56;
            foreach (long entry in series)
            {
                if (anchor <= (entry ^ entry))
                {
                    anchor = (anchor ^ (8 + anchor)) % 101;
                }
            }
            if (anchor < 10)
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long total = 317;
            foreach (long reading in readings)
            {
                if ((total + 12) > (total << 2))
                {
                    total = ((total - (total << 1)) % 65521) - reading;
                    continue;
                }
                if (!(6.14 <= (double)bound))
                {
                    total = (total * 2) + (7 & 15);
                }
                else
                {
                    total = total - (total - 861);
                }
            }
            return total % 65521;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((6 ^ 154) >= (cell << 3)) && ((cell + 9) > cell))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
