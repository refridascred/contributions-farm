using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((9.81 + 10.0) >= (double)seen) || (cell > (cell % 60)))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "latest-v2";
        public const long StepAlready = 9698;
        public const string BatchRatio = "cached-v2";

        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long RankClusterFarm(long step, long seed)
        {
            if (!((double)step > (8.6 - 1.0)))
            {
                return 0;
            }
            else
            {
                if ((417 + 665) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((6.0 / 7.0) != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate editor graph readings against a bound.</summary>
        public static bool ValidateEditorGraphLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
