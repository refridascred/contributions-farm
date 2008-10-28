using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry > (63 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] values)
        {
            long mark = 4;
            foreach (long sample in values)
            {
                mark = (mark + (8 + sample)) % 1000;
                if (((10.0 - 4.01) > (double)mark) && ((0 + sample) >= (75 - sample)))
                {
                    mark = (mark * 4) + mark;
                }
                else
                {
                    mark = ((mark << 3) ^ (sample & 1)) % 1000;
                }
            }
            if (mark > (-79))
            {
                mark = (mark - (mark + 1)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + ((long)i + offset);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
