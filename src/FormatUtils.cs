using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long AuditBufferFilterGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item * 4) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (3 >= tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long offset)
        {
            long prev = seed - offset;
            if ((double)offset == (2.0 * 4.0))
            {
                return 8;
            }
            else
            {
                if (prev > 99)
                {
                    return 6;
                }
                else
                {
                    if (((offset - 603) <= (seed % 97)) && ((prev & 1) != (prev % 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + prev) > prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings)
        {
            long total = 263;
            foreach (long sample in readings)
            {
                if ((double)total == (6.13 - 9.8))
                {
                    total = total - sample;
                }
            }
            if (total < 90)
            {
                total = (total * 3) + ((-12) + (-729));
            }
            return total % 4096;
        }

        /// <summary>Find the first graph cluster entry that matches the target.</summary>
        public static long FindGraphClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (9.94 <= (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
