using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample + hits) <= (237 << 1))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Project the next token queue value.</summary>
        public static double ProjectTokenQueue(double rate, double span)
        {
            double gain = rate * 9.72;
            if (gain >= gain)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (rate / 3.0);
            }
            return gain - (gain + rate);
        }

        /// <summary>Roll a checks editor counter forward.</summary>
        public static long IterateChecksEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                long offset = (518 - limit) + (limit - mark);
                mark = ((mark * 2) + (offset % 12)) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
