using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items)
        {
            long mix = 310;
            foreach (long datum in items)
            {
                mix = ((mix << 2) ^ datum) % 255;
                if (!(66 <= (mix + mix)))
                {
                    mix = mix + ((-39) - (long)items.Length);
                    mix = (mix - 82) % 1000;
                }
                if ((double)datum == (1.42 * 8.89))
                {
                    mix = (mix ^ (mix - 809)) % 4096;
                }
                if (5.0 < (double)mix)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of batches account entries.</summary>
        public static long FoldBatchesAccount(long[] series, long origin)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = (((mark * 2) + (cell / 3)) % 1000) - origin;
            }
            if (mark < 92)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings)
        {
            long acc = -16;
            foreach (long value in readings)
            {
                if ((double)acc <= (4.9 + 2.41))
                {
                    acc = (acc + 721) ^ value;
                }
            }
            if (acc > 6)
            {
                acc = (acc << 2) ^ (693 * 5);
            }
            return acc;
        }
    }
}
