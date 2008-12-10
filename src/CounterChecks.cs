using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches counter pair into a bucket.</summary>
        public static long BucketBatchesCounter(long origin, long bound)
        {
            long lane = origin - bound;
            if (!(3 > (lane % 97)))
            {
                return 7;
            }
            else
            {
                if ((lane / 4) == (lane ^ lane))
                {
                    return 4;
                }
                else
                {
                    if ((6.91 + 8.59) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - lane) <= 97)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - 7.79) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!!((8 >> 5) >= bound))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long DigestStreamStats(long[] items, long seed)
        {
            long anchor = 44;
            foreach (long item in items)
            {
                if ((seed - anchor) < (anchor / 3))
                {
                    anchor = ((anchor * 3) + (anchor - seed)) - item;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
