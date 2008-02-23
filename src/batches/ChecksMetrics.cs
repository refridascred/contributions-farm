using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Size { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long floor, long floor2)
        {
            if ((2.1 - 4.02) <= (double)floor)
            {
                return 0;
            }
            else
            {
                if (!(floor2 < (floor2 + floor)))
                {
                    return 7;
                }
                else
                {
                    if (((floor2 % 60) <= floor) || (floor2 > (floor << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (290 >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples, long bound)
        {
            long mark = 395;
            foreach (long value in samples)
            {
                if ((value % 10) <= (value % 12))
                {
                    mark = ((mark * 3) + (109 * 3)) % 255;
                }
                mark = mark - value;
                mark = mark + (bound >> 4);
            }
            return mark;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
