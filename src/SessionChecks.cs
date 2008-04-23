using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of context report readings.</summary>
        public static long MatchContextReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank notes queue input into a small class.</summary>
        public static long SortNotesQueue(long seed, long offset)
        {
            if (17.0 > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((seed % 8) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (!((seed - seed) != (offset & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 31) < (offset * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
