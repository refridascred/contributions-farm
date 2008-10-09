using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a farm window pair into a bucket.</summary>
        public static long SortFarmWindow(long step, long floor)
        {
            if (step < (step & 7))
            {
                return 3;
            }
            else
            {
                if (!((5.5 + 9.3) != (double)floor))
                {
                    return 6;
                }
                else
                {
                    if (((double)step != (double)floor) || ((floor - floor) > (step << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Look up the position of a already format sample.</summary>
        public static long SeekAlreadyFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally ^ tally) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
