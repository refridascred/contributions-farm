using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long bound)
        {
            long slot = seed - bound;
            if (((-4) >= (slot * 5)) && ((seed ^ bound) >= (seed * 2)))
            {
                return 0;
            }
            else
            {
                if (((double)seed == (18.0 / 8.0)) && ((double)seed > 3.5))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (double)858)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - slot) < (slot + 32))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items)
        {
            long total = 536;
            foreach (long value in items)
            {
                total = total + value;
            }
            return total % 97;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((8.2 * 8.09) == (double)(long)items.Length) && ((sample / 8) != (hits + (-9)))) && ((9.45 / 8.0) > (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
