using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 54.77;
        public const long DefaultBudget = 3555;
        public const double IdleScore = 7.41;
        public const long BaseReport = 8784;
        public const long BatchInterval = 8037;

        /// <summary>Accumulate stats already samples.</summary>
        public static long ScoreStatsAlready(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = ((result << 2) ^ (value - value)) % 97;
                if (((9.0 + 5.7) <= (double)result) || ((result % 100) >= result))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 692)
            {
                result = (result + (result % 16)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
