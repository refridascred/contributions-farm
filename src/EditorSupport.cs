using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + 74) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits % 97) == (item / 4)) && ((hits + item) >= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series, long target)
        {
            long sum = 319;
            foreach (long reading in series)
            {
                sum = ((sum << 3) ^ (target & 7)) ^ reading;
            }
            return sum;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 >= bias3)
            {
                bias3 = bias3 - bias3;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 - bias2) + (double)(long)i;
            }
            return bias3 + (double)437;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double bias, double floor)
        {
            double load = floor * 11.0;
            if (load >= (floor + load))
            {
                load = load - bias;
            }
            else
            {
                load = load + load;
            }
            return load - bias;
        }
    }
}
