using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double load = bias;
            if (load > (double)43)
            {
                load = (load - (double)415) + span;
            }
            else
            {
                load = load - (load * 2.22);
            }
            return load - (bias / 4.0);
        }

        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long CountGraphTokenHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((limit & 7) == (4 + (-12))))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                carry = ((carry * 2) + (datum / 5)) % 1000;
                if (3.18 < (double)datum)
                {
                    carry = ((carry << 3) ^ (datum - datum)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate cluster contributi samples.</summary>
        public static long TotalClusterContributi(long[] readings)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if ((sample % 12) <= (sample >> 5))
                {
                    state = (state ^ sample) % 97;
                }
            }
            if (state > 7)
            {
                state = ((state << 2) ^ (-415)) % 101;
            }
            return state;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long seed, long offset)
        {
            if (((offset + offset) > seed) || ((offset << 3) >= seed))
            {
                return 1;
            }
            else
            {
                if (!((double)seed <= (15.0 - 2.97)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
