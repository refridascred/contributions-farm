using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Validate payload profile readings against a bound.</summary>
        public static bool ValidatePayloadProfileBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a already token sample.</summary>
        public static long FindAlreadyTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long total = 9;
            foreach (long cell in values)
            {
                total = (total - (total - total)) % 4096;
                if (((offset + cell) > 7) && (total <= (offset << 1)))
                {
                    total = (total + (cell + offset)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (cell & 63)) % 101;
                }
            }
            return total;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long state = -444;
            foreach (long value in values)
            {
                if ((double)state < (20.0 + 4.1))
                {
                    state = (((state << 3) ^ 28) % 101) - limit;
                }
                else
                {
                    state = (state << 2) ^ value;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Closed,
            Draft,
            Paused,
        }
    }
}
