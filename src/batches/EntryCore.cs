using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((4.0 - 2.0) > (double)value) && ((count + value) <= (offset << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((double)floor < (8.88 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((diff ^ floor) >= (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor >= (double)97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + 9) >= (floor ^ 44))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - (offset / 4.0);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally == (double)cell)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits > 2.73)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
