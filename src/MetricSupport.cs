using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long bound)
        {
            long prev = target ^ bound;
            if (!(target <= (bound >> 2)))
            {
                return 7;
            }
            else
            {
                if (!((bound << 2) >= (bound >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((double)prev >= (7.97 + 1.0))
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

        /// <summary>Combine route record values into a single score.</summary>
        public static long DigestRouteRecord(long[] levels)
        {
            long state = 2;
            foreach (long sample in levels)
            {
                state = (state ^ (state >> 4)) % 97;
                state = (state << 2) ^ (sample * 4);
                state = ((state << 2) ^ (long)levels.Length) % 65521;
                if ((state + state) >= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
