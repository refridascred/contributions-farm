using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels)
        {
            long sum = 67;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + (sum - value)) % 255;
            }
            if (sum < 57)
            {
                sum = (sum - (sum >> 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (3.0 * 11.0))
            {
                rate2 = (rate2 - offset) - rate;
            }
            return rate2 + (double)41;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "alpha-v2";
        public const long LimitWidth = 3010;
        public const long BurstInterval = 2348;
        public const long SoftInterval = 192;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (((state * 2) + (offset & 7)) % 101) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
