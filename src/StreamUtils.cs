using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items, long target)
        {
            long acc = 3;
            foreach (long datum in items)
            {
                if (((target * 2) != (acc - target)) || ((target * 2) < (datum % 16)))
                {
                    acc = acc + (target / 2);
                }
                if (((target ^ 1) == (datum + 993)) && ((long)items.Length <= datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Roll a support notes counter forward.</summary>
        public static long IterateSupportNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if ((1.7 * 1.6) <= (double)step)
                {
                    mix = ((mix << 3) ^ mix) % 255;
                    mix = (mix + mix) % 101;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample / 3))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                if (((double)mix > (double)(long)items.Length) || ((offset << 3) >= (44 + offset)))
                {
                    mix = mix - (offset / 2);
                }
                else
                {
                    mix = (mix << 2) ^ (mix - reading);
                }
            }
            return mix % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((7.5 * 0.75) < (double)seed)
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (8.0 > (double)offset)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
