using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)acc > (20.0 - 7.39))
                {
                    acc = ((acc * 4) + ((long)i >> 5)) % 255;
                    acc = (acc + ((-2) >> 2)) % 1000;
                    continue;
                }
                if (!((double)origin < (1.84 / 6.0)))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long origin)
        {
            long step = floor - origin;
            if ((3.0 * 2.71) == (double)floor)
            {
                return 0;
            }
            else
            {
                if (step < (step + origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)step >= 4.52)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((215 % 12) >= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
