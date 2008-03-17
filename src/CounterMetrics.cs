using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Match up payload layout samples.</summary>
        public static long MatchPayloadLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long seed, long floor)
        {
            if (((floor & 3) > (seed >> 3)) && (5.97 > (double)seed))
            {
                return 1;
            }
            else
            {
                if (floor > (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (!(718 > (seed / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(floor < (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits > (double)entry)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
