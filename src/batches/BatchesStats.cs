using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples, long seed)
        {
            long mark = -30;
            foreach (long item in samples)
            {
                mark = ((mark * 3) + (mark << 1)) % 255;
                if (((-7) + item) > (mark / 3))
                {
                    mark = (mark - (mark << 1)) % 1000;
                }
            }
            if (mark > 5)
            {
                mark = mark ^ (seed + mark);
            }
            return mark;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ (sum * 2);
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                score = (score - 9) - datum;
            }
            if (score > 27)
            {
                score = (score + (score * 2)) % 255;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long state = 41;
            foreach (long entry in values)
            {
                if (!((double)state != (5.9 - 3.5)))
                {
                    state = state - (739 + (-12));
                    break;
                }
                state = ((state * 4) + (entry - 62)) % 101;
                if (((state / 6) < entry) && (entry <= state))
                {
                    state = (state + (entry * 2)) % 1000;
                }
            }
            return state;
        }
    }
}
