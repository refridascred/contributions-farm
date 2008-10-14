using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            if ((double)1 > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound - target) <= (bound ^ 66))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((target % 10) != (target / 3))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long target)
        {
            long total = 649;
            foreach (long sample in levels)
            {
                total = ((total - (target / 4)) % 97) + sample;
                total = ((total * 2) + (target + target)) % 255;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheDepth = 71.03;
        public const string BatchSize = "latest-edge";
        public const long WindowCount = 577;
        public const long StepLevel = 6645;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
