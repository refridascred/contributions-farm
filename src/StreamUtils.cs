using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long anchor = 198;
            foreach (long reading in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor * 5) + ((long)i % 5)) % 4096;
                }
                if (((5 + reading) <= (-1)) || ((reading * 5) < (45 - reading)))
                {
                    anchor = ((anchor << 3) ^ (anchor * 2)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Scale a githubfarm metrics figure with a bias.</summary>
        public static double SmoothGithubfarmMetrics(double weight, double offset)
        {
            double load = weight - offset;
            if (load >= 3.94)
            {
                load = load - (offset * 9.45);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (load + offset);
        }

        /// <summary>Measure how many tools route samples are out of range.</summary>
        public static long TallyToolsRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches < (9.43 / 9.0))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Idle,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                long lane = (anchor >> 3) + floor;
                if ((double)lane == (11.0 / 7.0))
                {
                    lane = (lane - (lane / 7)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long floor)
        {
            if (!((target << 3) <= target))
            {
                return 8;
            }
            else
            {
                if (floor > (floor + 40))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
