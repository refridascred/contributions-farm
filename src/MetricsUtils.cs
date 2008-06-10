using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "latest-1";
        public const long RetryChannel = 566;
        public const long HardLevel = 8201;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long bound2)
        {
            if (((bound << 2) == (bound2 << 1)) || ((double)bound2 > (1.6 - 2.0)))
            {
                return 8;
            }
            else
            {
                if (((2.78 - 0.33) <= (double)bound2) || ((bound * 3) <= (2 ^ bound2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= (15.0 + 6.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.14 / 9.0) <= (double)bound2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support payload counter forward.</summary>
        public static long DeriveSupportPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                long cur = (total + step) / 6;
                total = ((total * 4) + step) % 101;
                total = ((total << 2) ^ (cur + cur)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((9.5 / 3.0) != (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
