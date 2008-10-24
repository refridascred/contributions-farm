using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long bound)
        {
            long offset = target ^ bound;
            if ((target % 8) < (6 ^ (-531)))
            {
                return 8;
            }
            else
            {
                if ((target + target) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset - bound) > bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 4396;
        public const long IdleDepth = 3147;
        public const long BurstWidth = 6173;
        public const long LimitFilter = 2390;
        public const long MinCount = 4775;
    }
}
