using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long step)
        {
            long diff = target + step;
            if (diff < (step / 8))
            {
                return 1;
            }
            else
            {
                if (5 <= (diff << 3))
                {
                    return 5;
                }
                else
                {
                    if ((6.98 + 8.8) >= (double)step)
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

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 55.59;
        public const long DefaultLevel = 9422;
        public const double MinNotes = 29.08;
        public const double SoftNotes = 12.15;
        public const double IdleRatio = 60.54;
    }
}
