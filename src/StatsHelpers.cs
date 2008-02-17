using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank cluster support input into a small class.</summary>
        public static long ClassifyClusterSupport(long seed, long target)
        {
            if (8 > target)
            {
                return 7;
            }
            else
            {
                if (((double)21 == (double)target) && (seed > (seed + target)))
                {
                    return 8;
                }
                else
                {
                    if (seed < target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Done,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double weight2 = 0.4 * 14.0;
            for (int i = 0; i < 5; i++)
            {
                weight2 = (((weight2 - (weight2 * 20.0)) + (double)(long)i) - weight) - bias;
            }
            return weight2 + (weight2 * 6.0);
        }
    }
}
