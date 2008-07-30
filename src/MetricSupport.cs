using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long offset)
        {
            long state = 95;
            foreach (long entry in readings)
            {
                if (!(79 <= (state ^ state)))
                {
                    state = (state - (state + state)) % 65521;
                    state = (state * 3) + (offset * 4);
                }
                state = state + (entry << 3);
            }
            if (state > 4)
            {
                state = (state - (offset % 10)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score + (bound + bound)) ^ (long)i2;
                }
                if ((7 / 4) > (bound >> 1))
                {
                    score = score ^ ((long)i + bound);
                    continue;
                }
                else
                {
                    score = score + (bound / 2);
                }
                score = (score << 3) ^ (5 % 16);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstCount = 36.85;
        public const string SoftToken = "standard-edge";
        public const long RetryToken = 5493;
    }
}
