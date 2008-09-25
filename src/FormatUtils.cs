using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 10.0)
            {
                rate = rate + rate;
            }
            return rate + (ratio / 7.0);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample / 8) > (sample + sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + 233) > (hits % 16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total << 2) ^ (29 + (-719));
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long CountContributiClusterGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count != (7.88 - 6.3))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
