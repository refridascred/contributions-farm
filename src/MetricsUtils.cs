using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double bias = (double)(52 + 291);
            if (bias >= span)
            {
                bias = (bias + (span + span)) - weight;
            }
            return bias - (double)0;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long origin2)
        {
            if ((origin2 * 5) >= origin)
            {
                return 0;
            }
            else
            {
                if (((6.7 + 8.59) <= (double)origin) || ((origin2 + 20) != (origin << 1)))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin2 == (1.0 + 9.0)) && ((5.87 + 18.0) < (double)origin2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin2 - origin2) > origin2) || ((3.7 / 3.0) >= (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer graph pairs that satisfy a relation.</summary>
        public static long PairBufferGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long AuditProfileOrderGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((long)items.Length << 1) < bound))
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item ^ (long)readings.Length) < seen)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
