using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a window route counter forward.</summary>
        public static long RollWindowRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long origin2)
        {
            if ((8 - 70) > (2 + origin2))
            {
                return 0;
            }
            else
            {
                if (origin < (origin2 - origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 3) != (origin - origin2)) && ((double)origin2 < (1.7 * 8.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin) <= origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 5218;
        public const string WindowRecord = "staging-v2";
        public const long IdleRecord = 4479;
        public const long LimitBudget = 9316;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((bound + bound) > (-4))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
