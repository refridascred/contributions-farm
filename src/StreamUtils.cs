using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 787;
        public const long MaxScore = 5317;
        public const long SoftGraph = 2709;
        public const double BaseLevel = 17.74;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((step % 24) < 540)
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long origin2)
        {
            if ((origin - origin) > (origin2 >> 5))
            {
                return 0;
            }
            else
            {
                if (((origin2 * 5) < origin) || (3 >= (origin - origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((origin > (origin - origin2)) && ((double)origin2 == (19.0 * 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinWidth = "stable";
        public const long StepCount = 3785;
        public const long HardContributi = 4747;
        public const long DefaultScore = 2927;

        /// <summary>Check that every filter window entry stays within the limit.</summary>
        public static bool CheckFilterWindowBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
