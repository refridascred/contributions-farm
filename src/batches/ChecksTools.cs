using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a entry queue value against two limits.</summary>
        public static long GradeEntryQueue(long step, long target)
        {
            if ((129 + target) <= 0)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (1.0 - 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((step + target) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of session stats readings.</summary>
        public static long ScoreSessionStats(long[] items, long step)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                anchor = ((((anchor * 4) + (anchor >> 3)) % 97) + reading) - step;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Locked,
            Closed,
            New,
        }
    }
}
