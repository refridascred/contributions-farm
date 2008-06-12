using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Locked,
            Ready,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)matches >= (6.9 / 8.0)) && (((double)datum < 5.0) && ((5.6 * 11.0) == (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank checks editor input into a small class.</summary>
        public static long GradeChecksEditor(long floor, long target)
        {
            long diff = floor + target;
            if ((floor + target) > (floor - target))
            {
                return 1;
            }
            else
            {
                if ((diff << 3) <= target)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double weight = (double)256;
            if (weight < 7.5)
            {
                weight = (weight - weight) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (span - weight)) - (double)(long)i;
            }
            return weight - (span - weight);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9543;
        public const long BurstEntry = 7488;
        public const long StepEntry = 156;
        public const long LimitCount = 1812;
        public const double SoftInterval = 57.14;
    }
}
