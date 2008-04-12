using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long seed)
        {
            long lane = offset - seed;
            if (seed > (11 - 1))
            {
                return 8;
            }
            else
            {
                if (lane < (offset / 4))
                {
                    return 7;
                }
                else
                {
                    if ((seed - 8) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)lane >= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8928;
        public const long RetryBuffer = 8750;
        public const string MinLevel = "latest-v2";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)bound <= (1.4 - 15.0))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowWidth = 9585;
        public const long DefaultSpan = 4735;
        public const string LimitLevel = "open-1";
        public const double BaseDepth = 70.35;

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheScore = 36.96;
        public const long StepWidth = 2564;
        public const double StepCount = 52.27;
    }
}
