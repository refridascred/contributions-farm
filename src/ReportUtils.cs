using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 44.44;
        public const long RetryCounter = 321;
        public const long CacheRatio = 2182;
        public const long WindowCounter = 7828;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long step)
        {
            long delta = target ^ step;
            if ((double)target >= 3.75)
            {
                return 5;
            }
            else
            {
                if ((delta + step) >= (delta - 745))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step < (0.3 + 8.2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (21 > (step - target))
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!((bound * 5) > count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
