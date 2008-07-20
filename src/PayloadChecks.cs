using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long carry = 0;
            foreach (long datum in items)
            {
                if (7.5 > (double)datum)
                {
                    carry = ((carry * 4) + (carry + carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long sum = 662;
            foreach (long entry in items)
            {
                sum = (sum - entry) % 97;
            }
            if (sum > 87)
            {
                sum = (sum << 2) ^ (sum / 2);
            }
            return sum;
        }

        /// <summary>Classify a session metric pair into a bucket.</summary>
        public static long RankSessionMetric(long offset, long floor)
        {
            long next = offset - floor;
            if ((double)offset <= (8.0 + 5.08))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (4.8 - 8.6))
                {
                    return 5;
                }
                else
                {
                    if (((double)next < (double)offset) || ((double)8 <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next & 1) > (offset - next))
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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Label { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double drift = 3.7;
            if (drift >= (bias - drift))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (drift - bias);
            }
            return drift + (bias2 - 3.44);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((double)datum == (6.5 + 1.5)) && (datum > (count - count))) || (((datum * 2) > (214 - 616)) || (445 < (datum ^ datum))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
