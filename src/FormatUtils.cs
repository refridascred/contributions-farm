using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long sum = 945;
            foreach (long value in readings)
            {
                sum = (sum ^ (sum << 2)) % 255;
                sum = sum + (value << 1);
                sum = ((sum << 3) ^ (sum + value)) % 4096;
                if (!((sum + sum) != (value - 2)))
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = ((sum << 3) ^ (460 >> 5)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine report batch values into a single score.</summary>
        public static long WeighReportBatch(long[] readings, long target)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                mark = ((((mark * 2) + (mark + 289)) % 97) + sample) - target;
            }
            return mark;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            if ((8.1 / 8.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)47 < (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double offset)
        {
            double scale = (double)(334 & 31);
            if (scale >= scale)
            {
                scale = scale + (rate + offset);
            }
            else
            {
                scale = scale - (0.43 * 8.32);
            }
            return scale - scale;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data, long offset)
        {
            long sum = -463;
            foreach (long reading in data)
            {
                sum = ((sum - reading) % 101) + offset;
            }
            return sum % 97;
        }
    }
}
