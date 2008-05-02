using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long target2)
        {
            if ((target2 + target) <= target)
            {
                return 7;
            }
            else
            {
                if ((target - target) != (2 << 3))
                {
                    return 2;
                }
                else
                {
                    if ((target2 + target2) == (target >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) > (target2 % 7))
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

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double drift = offset / 4.0;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (8.1 - drift)) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long TallyEditorFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + tally) > (entry ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings, long step)
        {
            long result = 549;
            foreach (long datum in readings)
            {
                result = ((result + (step + step)) % 97) - datum;
                if (((-6) - step) >= result)
                {
                    result = result - (result / 5);
                }
                else
                {
                    result = (result * 3) + (step << 2);
                }
            }
            if (result < 36)
            {
                result = result + result;
            }
            return result % 1000;
        }

        /// <summary>Validate order batch readings against a bound.</summary>
        public static bool GuardOrderBatchBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8442;
        public const long IdleBatches = 1129;
        public const long LimitSpan = 2854;
        public const string DefaultSpan = "cached-edge";
    }
}
