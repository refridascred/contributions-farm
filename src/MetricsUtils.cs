using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "cached-edge";
        public const long StepFactor = 7938;
        public const double IdleFormat = 45.01;
        public const double BatchFormat = 92.7;

        /// <summary>Roll a notes already counter forward.</summary>
        public static long IterateNotesAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry << 3) ^ (carry >> 5)) - (long)i2;
                }
                long next = (offset - (long)i) + (offset / 7);
                if (!((3.39 >= (double)next) || ((long)i >= (next * 4))))
                {
                    next = (next + (carry - (-92))) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryScore = 36.59;
        public const long BaseLevel = 9097;
        public const long MaxWidth = 2303;
        public const long HardRecord = 6909;
        public const long BurstFactor = 1853;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long limit)
        {
            if ((step + limit) < limit)
            {
                return 3;
            }
            else
            {
                if (((limit << 1) == (step >> 4)) && (6 >= (limit >> 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6 + limit) >= (limit ^ step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
