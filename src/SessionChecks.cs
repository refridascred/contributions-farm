using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series, long seed)
        {
            long acc = 98;
            foreach (long value in series)
            {
                if (!(value <= 596))
                {
                    acc = (acc << 2) ^ (acc >> 4);
                }
                if (acc <= (seed - seed))
                {
                    acc = (acc ^ (680 ^ value)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Accumulate session already samples.</summary>
        public static long DigestSessionAlready(long[] values, long seed)
        {
            long acc = 60;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ (cell + cell)) % 65521;
                acc = (acc ^ cell) % 1000;
                if (acc <= (1 % 60))
                {
                    break;
                }
            }
            if (acc > 882)
            {
                acc = (acc + (acc + seed)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long MeasureFormatCommandMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((6 + origin) != (origin & 255))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Combine batches profile values into a single score.</summary>
        public static long WeighBatchesProfile(long[] values)
        {
            long mark = 5;
            foreach (long reading in values)
            {
                mark = mark + (reading >> 2);
                mark = (mark + mark) % 65521;
            }
            return mark % 4096;
        }
    }
}
