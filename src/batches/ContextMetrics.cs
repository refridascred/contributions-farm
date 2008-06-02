using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Active,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Grade a cluster farm value against two limits.</summary>
        public static long SortClusterFarm(long limit, long origin)
        {
            if ((double)origin >= 19.0)
            {
                return 5;
            }
            else
            {
                if ((origin > (limit * 4)) && ((limit - limit) <= origin))
                {
                    return 1;
                }
                else
                {
                    if (((8.8 - 7.0) < (double)origin) || ((0 / 3) != (limit * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 44.4;
        public const string HardLevel = "legacy-edge";
        public const long MaxBatch = 8308;
        public const double StepFactor = 36.0;
        public const double MaxWidth = 87.74;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
