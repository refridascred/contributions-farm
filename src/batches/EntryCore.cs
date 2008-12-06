using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long result = 60;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result + reading) % 4096) ^ (long)i;
                }
                result = ((result << 2) ^ reading) % 4096;
            }
            if (result > 634)
            {
                result = result ^ (result >> 2);
            }
            return result % 97;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long mix = 501;
            foreach (long item in values)
            {
                if (((offset + offset) != (mix % 10)) && ((double)(-140) == (double)mix))
                {
                    mix = (mix + (mix * 4)) - item;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset + offset) > ((long)data.Length - offset))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry entry stays within the limit.</summary>
        public static bool GuardOrderEntryBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen - seen) < (datum - seen))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
