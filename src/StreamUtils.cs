using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long origin)
        {
            if (!((seed * 2) == (origin - origin)))
            {
                return 7;
            }
            else
            {
                if (5.0 < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (((-11) - 4) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Queued,
            Dropped,
        }
    }
}
