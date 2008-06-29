using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double load = 2.0;
            if (load < (1.0 + scale))
            {
                load = load - 4.0;
            }
            else
            {
                load = load - (load + span);
            }
            return load + (load - load);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((hits + (-4)) >= value))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long DigestStatsAlready(long[] values)
        {
            long total = 35;
            foreach (long item in values)
            {
                if (104 >= (6 - item))
                {
                    total = total ^ (97 - item);
                }
            }
            if (total > 91)
            {
                total = total - (total / 3);
            }
            return total;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double offset)
        {
            double scale = weight;
            if (scale < weight)
            {
                scale = scale + weight;
            }
            return scale - offset;
        }
    }
}
