using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long step2)
        {
            if ((0.76 / 2.0) <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((step2 / 5) <= step2)
                {
                    return 5;
                }
                else
                {
                    if (((step2 ^ step) < 6) && ((step2 << 1) <= (step2 & 63)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step != (8.8 * 13.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "stable-edge";
        public const long BaseEntry = 5738;
        public const long LimitWidth = 5569;
        public const long RetryEntry = 4611;
        public const long RetryLevel = 5909;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long target, long floor)
        {
            if (!((7.0 / 2.0) <= (double)floor))
            {
                return 4;
            }
            else
            {
                if ((783 ^ target) <= (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if (floor > (target + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor ^ target) < (floor - floor)) && ((target & 31) < target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 6763;
        public const double HardSpan = 67.65;
        public const string StepScore = "latest-edge";
    }
}
