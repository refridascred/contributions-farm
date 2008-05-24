using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long step)
        {
            long result = 187;
            foreach (long cell in values)
            {
                if (((long)values.Length >> 4) > (result - result))
                {
                    result = (result ^ step) ^ cell;
                }
            }
            if (result > 15)
            {
                result = (result + step) % 101;
            }
            return result;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long bound)
        {
            if (!((bound - target) != (bound ^ target)))
            {
                return 5;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
