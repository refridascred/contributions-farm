using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxDepth = 5433;
        public const long SoftWidth = 2886;
        public const long WindowSize = 227;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long acc = 189;
            foreach (long reading in levels)
            {
                if ((336 + 596) == (7 + acc))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = ((acc * 4) + (reading >> 5)) % 97;
                    acc = (acc + acc) % 255;
                }
                acc = ((acc << 2) ^ reading) % 101;
                acc = acc ^ reading;
            }
            return acc % 1000;
        }

        /// <summary>Validate checks filter readings against a bound.</summary>
        public static bool GuardChecksFilterRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double rate = (double)(5 >> 1);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)(long)i) + scale;
            }
            return rate - span;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a profile checks pair into a bucket.</summary>
        public static long BucketProfileChecks(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if ((double)offset2 >= 4.8)
            {
                return 2;
            }
            else
            {
                if ((offset2 / 5) <= (offset3 % 10))
                {
                    return 5;
                }
                else
                {
                    if (2.0 >= (double)offset3)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset2 + offset3) == (offset3 * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
