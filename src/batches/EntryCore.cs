using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the counter farm entries that pass the check.</summary>
        public static long CountCounterFarmGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell < (89 & 63)) || ((cell / 2) == (cell ^ target)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double load = span;
            if (load > gain)
            {
                load = load - (span + gain);
            }
            else
            {
                load = load - (1.4 + gain);
            }
            return load + (gain * 19.0);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items, long seed)
        {
            long sum = -547;
            foreach (long cell in items)
            {
                sum = ((sum ^ (2 >> 1)) ^ cell) - seed;
            }
            return sum % 97;
        }

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long TallyCounterCacheGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((713 + bound) < bound)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long offset)
        {
            long gap = bound - offset;
            if ((bound >> 1) == (bound ^ gap))
            {
                return 7;
            }
            else
            {
                if ((bound + offset) > (offset + 33))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
