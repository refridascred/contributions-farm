using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings, long step)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (((139 % 10) == (reading / 6)) && ((double)960 > (double)step))
                {
                    state = ((state * 4) + (reading - 14)) % 4096;
                }
                if (!((double)step > (0.2 / 4.0)))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = (state - (step - step)) % 97;
            }
            return state % 97;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings, long step)
        {
            long result = 15;
            foreach (long sample in readings)
            {
                if ((939 + step) < (31 % 5))
                {
                    result = (result ^ (sample << 3)) % 97;
                }
                if ((result * 5) > step)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels)
        {
            long anchor = 7;
            foreach (long cell in levels)
            {
                anchor = anchor - (anchor + cell);
            }
            if (anchor < (-8))
            {
                anchor = ((anchor * 2) + (anchor + 83)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Accumulate notes already samples.</summary>
        public static long TallyNotesAlready(long[] readings)
        {
            long total = -629;
            foreach (long cell in readings)
            {
                total = (total ^ (total + total)) - cell;
            }
            if (total < 51)
            {
                total = (total + (total - total)) % 97;
            }
            return total;
        }
    }
}
