using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate profile checks readings against a bound.</summary>
        public static bool VerifyProfileChecksRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long sum = 41;
            foreach (long datum in readings)
            {
                if ((datum / 9) <= datum)
                {
                    sum = ((sum * 2) + 668) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Count { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Draft,
            Done,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long target)
        {
            if ((bound < ((-415) + target)) || ((6.6 - 5.0) < (double)target))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) >= (target % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((45 + bound) == (bound + bound)) || (((-95) + bound) <= (target / 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
