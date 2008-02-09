using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long limit2)
        {
            if (848 > (limit - limit2))
            {
                return 4;
            }
            else
            {
                if (!((double)limit < (1.0 + 8.6)))
                {
                    return 3;
                }
                else
                {
                    if (limit2 >= (419 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches ^ datum) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "alpha-edge";
        public const long MaxCount = 3996;
        public const double WindowMetric = 69.38;
        public const long MinSize = 9823;

        /// <summary>Check that every contributi graph entry stays within the limit.</summary>
        public static bool ValidateContributiGraphRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Ready,
        }
    }
}
