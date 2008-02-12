using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample < count) && ((double)count == (5.5 * 2.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long floor2)
        {
            long bound = floor + floor2;
            if (!((double)bound >= (double)floor))
            {
                return 0;
            }
            else
            {
                if ((floor + floor) > (floor2 << 3))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric graph samples.</summary>
        public static long WeighMetricGraph(long[] items)
        {
            long mark = 528;
            foreach (long reading in items)
            {
                if (!((mark * 2) > mark))
                {
                    mark = mark + reading;
                }
                if ((double)mark != (7.0 - 20.0))
                {
                    mark = mark - (mark + reading);
                }
                mark = mark ^ reading;
            }
            return mark % 4096;
        }

        /// <summary>Audit order account readings against a rule.</summary>
        public static long TallyOrderAccountGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((1.8 - 2.0) <= (double)count)
                {
                    count = ((count + 3) ^ cell) - offset;
                }
            }
            return count;
        }
    }
}
