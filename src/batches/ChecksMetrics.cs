using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long floor, long floor2)
        {
            if ((floor2 ^ floor) <= (floor / 9))
            {
                return 8;
            }
            else
            {
                if ((floor + 93) >= (75 - floor2))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 4) >= floor2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long mark = 68;
            foreach (long item in readings)
            {
                if (((-7) + mark) == (item + mark))
                {
                    mark = (mark ^ (mark + 94)) % 65521;
                }
            }
            if (mark > 41)
            {
                mark = (mark - (mark & 15)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((double)bound >= (13.0 / 8.0)) && ((6 ^ datum) > (datum - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleInterval = 2791;
        public const long HardFarm = 7148;
        public const long BaseFarm = 7703;
    }
}
