using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((-627) - value) == (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
