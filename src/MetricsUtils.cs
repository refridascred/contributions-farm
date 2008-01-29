using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long step)
        {
            if (((7.8 - 4.2) >= (double)offset) || ((6 << 3) <= (offset % 16)))
            {
                return 4;
            }
            else
            {
                if ((step < offset) && ((offset - 678) != (offset - 611)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long bound)
        {
            if (!((9.91 / 9.0) == (double)target))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (5.12 - 7.43))
                {
                    return 7;
                }
                else
                {
                    if (4.0 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound & 255) != (target - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels)
        {
            long acc = -9;
            foreach (long sample in levels)
            {
                long seen = (acc + acc) - ((-38) + 50);
                if (!((((long)levels.Length << 1) <= (acc & 127)) || ((61 * 5) >= (seen + sample))))
                {
                    acc = acc - seen;
                }
                acc = (acc ^ (sample % 5)) % 255;
            }
            if (acc < (-101))
            {
                acc = ((acc << 2) ^ (acc << 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > (bias * 2.33))
            {
                bias2 = bias2 - (6.0 * 2.0);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias2;
        }
    }
}
