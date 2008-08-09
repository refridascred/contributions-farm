using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(item < (item << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long step)
        {
            long edge = limit + step;
            if (((step ^ 39) < (limit / 5)) || (step < (step + (-57))))
            {
                return 8;
            }
            else
            {
                if ((edge << 2) <= (step / 7))
                {
                    return 0;
                }
                else
                {
                    if (((double)limit > (8.25 / 8.0)) && (((-65) - step) >= (limit - 913)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long DeriveClusterChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result + step) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5906;
        public const long DefaultSchema = 1517;
        public const double MaxWidth = 4.21;
        public const double CacheSchema = 13.41;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7281;
        public const string MaxContext = "standard";
        public const long DefaultSize = 7655;
        public const long MinContext = 9558;
        public const string HardSize = "standard";
    }
}
