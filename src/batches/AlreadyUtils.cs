using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of graph token entries.</summary>
        public static long FoldGraphToken(long[] samples)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                if ((double)acc == (7.7 + 6.0))
                {
                    acc = ((acc - (acc & 15)) % 255) - sample;
                }
            }
            return acc;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long step, long seed)
        {
            if (((6.46 - 10.0) < (double)step) && (8 < (seed << 1)))
            {
                return 1;
            }
            else
            {
                if ((((-5) ^ seed) != (step ^ seed)) || ((step - 0) != (step / 6)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed != (6.47 * 18.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2 & 31) <= step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (820 ^ datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long StepLayoutBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = carry ^ carry;
                if ((double)step >= (double)carry)
                {
                    carry = ((carry << 3) ^ ((long)i - (long)i)) % 97;
                    carry = (carry ^ (carry >> 5)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
