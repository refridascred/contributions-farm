using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                if (((14.0 + 1.9) == (double)target) && ((6.7 * 4.8) == (double)target))
                {
                    score = score - (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepRatio = 63.65;
        public const long SoftChannel = 8873;
        public const double RetryChannel = 86.8;
        public const double DefaultChannel = 38.77;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long floor)
        {
            if (3 < (floor + 906))
            {
                return 8;
            }
            else
            {
                if ((target + floor) > (floor & 255))
                {
                    return 0;
                }
                else
                {
                    if ((target + floor) < (4 + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
