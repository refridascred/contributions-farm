using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 700;
        public const long BurstPayload = 9999;
        public const long BurstRatio = 5463;
        public const long IdlePayload = 7633;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long target)
        {
            long bound = step - target;
            if ((2.0 + 6.54) != (double)bound)
            {
                return 3;
            }
            else
            {
                if ((4.0 + 20.0) > (double)target)
                {
                    return 5;
                }
                else
                {
                    if (4.5 > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step >= 6.64)
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

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen <= (14.0 + 7.6))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
