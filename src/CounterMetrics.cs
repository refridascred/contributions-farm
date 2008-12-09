using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate layout metrics samples.</summary>
        public static long TallyLayoutMetrics(long[] samples, long floor)
        {
            long score = 779;
            foreach (long reading in samples)
            {
                if (!((double)floor <= 6.2))
                {
                    score = ((score + (floor << 3)) % 1000) ^ reading;
                }
                else
                {
                    score = ((score * 3) + (floor ^ 975)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank layout githubfarm input into a small class.</summary>
        public static long SortLayoutGithubfarm(long floor, long limit)
        {
            long lane = floor + limit;
            if (!((double)lane > (double)708))
            {
                return 8;
            }
            else
            {
                if ((582 - lane) < (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if (4 > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long floor)
        {
            long step = bound + floor;
            if ((floor / 7) != (floor & 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.59 / 2.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
