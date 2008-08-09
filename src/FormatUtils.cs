using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values)
        {
            long sum = 57;
            foreach (long datum in values)
            {
                sum = ((sum * 3) + (sum % 100)) + datum;
            }
            return sum;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (seed % 97)) % 1000;
                if ((seed ^ carry) != (seed + (long)i))
                {
                    carry = (carry << 2) ^ (seed >> 1);
                    carry = carry - ((long)i ^ carry);
                }
                if ((8.1 >= (double)carry) || ((7.75 * 8.08) <= (double)carry))
                {
                    carry = carry + carry;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double scale = (span + ratio) * 9.0;
            if (scale > (double)(-95))
            {
                scale = scale + span;
            }
            return scale + ratio;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
