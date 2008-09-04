using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long RollFarmTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score << 3) ^ ((long)i * 4);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series, long bound)
        {
            long carry = 859;
            foreach (long sample in series)
            {
                if (sample > (7 >> 5))
                {
                    carry = (carry - 10) + bound;
                }
            }
            return carry % 65521;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings, long offset)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (!((double)score >= (double)sample))
                {
                    score = (score - (sample * 4)) - offset;
                }
            }
            return score % 4096;
        }
    }
}
