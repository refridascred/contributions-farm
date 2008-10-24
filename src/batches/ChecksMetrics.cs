using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((prev >= (882 << 3)) && ((offset % 60) != ((-738) * 4)))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (double)70)
                {
                    return 1;
                }
                else
                {
                    if (!((offset * 4) == (bound >> 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            long span = seed ^ limit;
            if ((3.9 - 5.9) != (double)span)
            {
                return 1;
            }
            else
            {
                if ((double)limit == (20.0 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if (((11.0 + 6.92) <= (double)limit) && (0 >= (span << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample + offset) <= ((long)readings.Length << 1)) || (((1.0 / 3.0) >= (double)offset) && (9.5 >= (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 4396;
        public const long IdleDepth = 3147;
        public const long BurstWidth = 6173;
        public const long LimitFilter = 2390;
        public const long MinCount = 4775;
    }
}
