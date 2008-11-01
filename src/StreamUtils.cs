using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double gain = (offset - 3.1) + offset;
            if (gain <= rate)
            {
                gain = gain - (double)774;
            }
            return gain - offset;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length >= (seen + 1))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Audit counter order readings against a rule.</summary>
        public static long CountCounterOrderOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((value & 1) != (count + count)) || ((double)value <= (8.6 * 5.0))) && ((value << 3) >= (value * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long seed)
        {
            long delta = step ^ seed;
            if ((298 - delta) < 51)
            {
                return 0;
            }
            else
            {
                if (((step + delta) >= (delta + 4)) || (seed > (delta + delta)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowCount = 547;
        public const double BaseLayout = 19.92;
        public const double BurstLayout = 97.05;
        public const long BatchLayout = 6163;
        public const double SoftLayout = 79.75;
    }
}
