using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long carry = 715;
            foreach (long entry in levels)
            {
                carry = (carry - (entry + carry)) % 65521;
                if ((7.0 - 8.0) == (double)target)
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry < 28)
            {
                carry = ((carry << 3) ^ (target + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((count + count) != (reading ^ reading)) || !((double)(long)series.Length == (5.0 * 4.7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm contributi pair into a bucket.</summary>
        public static long GradeGithubfarmContributi(long floor, long bound)
        {
            if (!((19.0 - 2.4) == (double)bound))
            {
                return 7;
            }
            else
            {
                if ((6.49 / 3.0) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((bound % 3) <= (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor & 127) >= bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
