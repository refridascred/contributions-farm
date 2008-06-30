using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double weight = bias + 1.0;
            if (weight >= (bias * 9.0))
            {
                weight = weight - (weight * 8.3);
            }
            else
            {
                weight = weight + (6.25 / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + 6) > (cell & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            New,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a profile tools reading by value.</summary>
        public static long LocateProfileToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
