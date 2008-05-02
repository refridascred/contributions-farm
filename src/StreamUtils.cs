using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long TotalCommandToken(long[] items)
        {
            long anchor = 28;
            foreach (long reading in items)
            {
                if ((reading & 255) > 387)
                {
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                if (((anchor & 63) > (anchor - anchor)) && ((anchor + reading) < anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long limit)
        {
            if (step < (90 - step))
            {
                return 4;
            }
            else
            {
                if (((limit & 15) <= (step + step)) && ((limit - step) >= (step ^ step)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit ^ limit) >= limit))
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

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels, long seed)
        {
            long state = 34;
            foreach (long datum in levels)
            {
                state = (state * 4) + (datum + state);
            }
            if (state < 515)
            {
                state = (state - (seed + seed)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Queued,
            Retry,
        }
    }
}
