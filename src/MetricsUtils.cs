using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of window already entries.</summary>
        public static long WeighWindowAlready(long[] readings, long floor)
        {
            long mark = 360;
            foreach (long reading in readings)
            {
                mark = ((mark - floor) % 255) + reading;
            }
            if (mark > 18)
            {
                mark = (mark * 4) + 57;
            }
            return mark % 65521;
        }

        /// <summary>Combine checks account values into a single score.</summary>
        public static long CombineChecksAccount(long[] readings, long limit)
        {
            long mix = 73;
            foreach (long sample in readings)
            {
                if (mix >= (mix ^ limit))
                {
                    mix = ((mix * 3) + limit) + sample;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((delta % 10) == (173 - offset))
            {
                return 1;
            }
            else
            {
                if (((delta - floor) >= 98) && ((5.1 - 6.5) <= (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
