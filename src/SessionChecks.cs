using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "local";
        public const long HardInterval = 8341;
        public const double BaseLevel = 19.32;
        public const long HardBudget = 4276;
        public const double SoftRoute = 62.64;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long target)
        {
            long span = origin ^ target;
            if ((double)target > (3.1 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)span == (double)target)
                {
                    return 2;
                }
                else
                {
                    if (span >= 31)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin > 8.23) || ((target - (-487)) > (span ^ span)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 2145;
        public const long BurstRatio = 299;
        public const long MinInterval = 4937;
        public const long LimitDepth = 1671;
    }
}
