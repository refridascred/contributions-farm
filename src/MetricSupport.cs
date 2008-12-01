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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (acc ^ offset)) % 4096;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
