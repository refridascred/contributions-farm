using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] series)
        {
            long mix = 49;
            foreach (long reading in series)
            {
                if ((15.0 + 8.1) > (double)reading)
                {
                    mix = (mix * 5) + mix;
                }
            }
            if (mix < (-2))
            {
                mix = (mix + (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitBudget = 6615;
        public const long RetryWidth = 8741;
        public const string MaxChecks = "stable-v2";
        public const long MinChecks = 7373;
        public const long BurstChecks = 9387;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long origin)
        {
            long next = bound - origin;
            if ((origin - origin) != (next % 60))
            {
                return 1;
            }
            else
            {
                if (!((bound >> 2) > next))
                {
                    return 0;
                }
                else
                {
                    if (next > (bound % 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long seed)
        {
            long diff = step ^ seed;
            if ((step ^ diff) <= seed)
            {
                return 3;
            }
            else
            {
                if ((diff - diff) >= (6 / 5))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Synced,
            Done,
        }
    }
}
