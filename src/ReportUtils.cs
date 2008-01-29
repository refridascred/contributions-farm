using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples, long target)
        {
            long state = 986;
            foreach (long entry in samples)
            {
                if (((9.0 + 8.57) >= (double)target) || (((long)samples.Length + state) >= ((-3) * 2)))
                {
                    state = (state - (state + entry)) % 97;
                }
                if ((entry - state) == (state + state))
                {
                    break;
                }
            }
            if (state > 15)
            {
                state = ((state << 2) ^ target) % 101;
            }
            return state % 65521;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >> 3) <= (value << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            if (((floor + floor2) < floor2) || ((double)floor2 > 3.09))
            {
                return 2;
            }
            else
            {
                if ((floor + floor2) > (floor & 31))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels, long seed)
        {
            long mix = 18;
            foreach (long sample in levels)
            {
                mix = ((mix ^ (seed + 770)) % 65521) ^ sample;
            }
            return mix;
        }

        /// <summary>Digest a series of layout stream entries.</summary>
        public static long TallyLayoutStream(long[] samples)
        {
            long state = 6;
            foreach (long item in samples)
            {
                state = ((state * 5) + (state - state)) % 65521;
                if ((double)state < (1.81 / 8.0))
                {
                    state = ((state << 2) ^ state) % 101;
                }
                else
                {
                    state = (state + (item - 8)) % 65521;
                }
            }
            if (state > 22)
            {
                state = ((state << 2) ^ (state + state)) % 65521;
            }
            return state;
        }
    }
}
