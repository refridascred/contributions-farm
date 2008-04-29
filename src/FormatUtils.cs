using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings, long target)
        {
            long result = 83;
            foreach (long entry in readings)
            {
                result = ((result + ((-173) & 1)) - entry) - target;
                result = (result ^ (result * 5)) % 255;
            }
            if (result < 89)
            {
                result = ((result * 3) + result) % 65521;
            }
            return result;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((origin << 2) > (seen - 853))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long floor, long origin)
        {
            if ((origin - origin) <= (origin / 9))
            {
                return 1;
            }
            else
            {
                if ((0.31 + 0.93) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 / 9.0) >= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LookupOrderClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream route value.</summary>
        public static double BlendStreamRoute(double ratio, double span)
        {
            double mean = span;
            return (mean + mean) + ratio;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Ready,
            Active,
        }
    }
}
