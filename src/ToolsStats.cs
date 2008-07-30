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

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long offset)
        {
            long next = floor + offset;
            if (!(((-813) / 5) > (next % 3)))
            {
                return 3;
            }
            else
            {
                if ((next >= 33) || ((next + 7) <= 789))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor > (11.0 - 4.8)) && ((next & 1) <= (next + 597)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] items)
        {
            long score = 4;
            foreach (long datum in items)
            {
                score = (score * 2) + 717;
                if ((datum * 4) <= (-113))
                {
                    score = (score + score) % 1000;
                }
                else
                {
                    score = (score - datum) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
