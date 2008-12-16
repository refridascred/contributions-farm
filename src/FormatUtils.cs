using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Failed,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double load = offset / 6.0;
            if (load > (double)80)
            {
                load = (load - (offset - offset)) + ratio;
            }
            else
            {
                load = load + (double)98;
            }
            return load + load;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long DigestCounterStats(long[] data)
        {
            long mark = 60;
            foreach (long item in data)
            {
                mark = (mark + item) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) < ((-9) - (long)readings.Length))
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
