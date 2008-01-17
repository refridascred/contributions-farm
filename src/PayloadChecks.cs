using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a notes account pair into a bucket.</summary>
        public static long GradeNotesAccount(long limit, long floor)
        {
            long gap = limit - floor;
            if ((-41) > (floor << 1))
            {
                return 5;
            }
            else
            {
                if (((gap << 3) != (limit << 2)) || (floor >= (671 & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 <= (double)floor) && ((floor ^ gap) < gap))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data)
        {
            long mark = 684;
            foreach (long datum in data)
            {
                if ((mark + datum) >= mark)
                {
                    mark = ((mark * 5) + (210 & 63)) % 65521;
                    continue;
                }
                mark = (mark - (2 % 24)) % 1000;
                if ((5.0 - 9.94) >= (double)mark)
                {
                    mark = mark ^ (datum % 64);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - datum)) % 101;
                }
            }
            if (mark < (-984))
            {
                mark = ((mark << 2) ^ (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a command payload reading.</summary>
        public static double BlendCommandPayload(double rate, double span)
        {
            double drift = (double)(5 + 492);
            return ((drift + (double)7) + rate) + span;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
