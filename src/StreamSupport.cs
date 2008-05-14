using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long offset)
        {
            long mark = -365;
            foreach (long value in readings)
            {
                if ((mark % 12) > value)
                {
                    mark = mark ^ 70;
                }
                mark = mark ^ (mark - offset);
            }
            return mark % 4096;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double mean = span / 9.0;
            if (mean >= (double)(-8))
            {
                mean = (mean + (double)5) + scale;
            }
            return mean + (span / 3.0);
        }
    }
}
