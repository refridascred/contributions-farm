using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinTimeout = 8406;
        public const long HardCommits = 2059;
        public const long BatchCommits = 1205;
        public const long StepFactor = 8367;
        public const long BatchCount = 4741;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long origin)
        {
            if ((limit > (origin + origin)) || ((limit + origin) >= (origin - limit)))
            {
                return 7;
            }
            else
            {
                if ((origin + 791) != (origin & 15))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin > 1.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.03 - 2.0) <= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
