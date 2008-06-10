using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long offset)
        {
            long sum = 73;
            foreach (long cell in values)
            {
                if (((3.58 * 4.49) > (double)cell) && (387 <= sum))
                {
                    long offset2 = (offset - sum) / 2;
                    sum = ((sum * 2) + offset2) % 101;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + (cell + cell);
                    sum = ((sum * 5) + (offset + cell)) % 4096;
                }
                if (offset > (offset / 9))
                {
                    sum = (sum - (sum + offset)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels)
        {
            long mark = 37;
            foreach (long datum in levels)
            {
                if ((double)datum == (12.0 / 8.0))
                {
                    mark = mark + (mark + datum);
                }
                else
                {
                    mark = (mark + mark) % 4096;
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((step + step) == (hits & 63))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double scale, double span)
        {
            double mean = (span * 0.1) / 3.0;
            if (mean <= (double)836)
            {
                mean = (mean + span) - scale;
            }
            return mean + mean;
        }
    }
}
