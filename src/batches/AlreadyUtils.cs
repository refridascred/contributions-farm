using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Stale,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((653 + limit) != (limit - cell)) || ((510 / 5) > cell))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor tools value against two limits.</summary>
        public static long BucketEditorTools(long seed, long offset)
        {
            long delta = seed + offset;
            if ((seed & 7) > (delta + 84))
            {
                return 3;
            }
            else
            {
                if ((offset >> 5) == (seed - delta))
                {
                    return 1;
                }
                else
                {
                    if (((seed % 3) >= (9 + delta)) || (delta < (seed - delta)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long ScoreStreamPayload(long[] levels, long step)
        {
            long state = 7;
            foreach (long item in levels)
            {
                if ((double)step != (double)item)
                {
                    state = state + (step * 3);
                }
                else
                {
                    state = ((state * 3) + state) % 255;
                }
            }
            if (state > 8)
            {
                state = (state - 0) % 255;
            }
            return state;
        }

        /// <summary>Look up the position of a order stats sample.</summary>
        public static long SeekOrderStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
