using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 76.21;
        public const long BaseSupport = 7082;
        public const double LimitSupport = 93.18;

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long seed)
        {
            if (!((seed % 10) >= (floor & 3)))
            {
                return 6;
            }
            else
            {
                if ((seed + floor) >= (seed ^ 633))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the checks stream series from a seed.</summary>
        public static long DeriveChecksStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)anchor < (6.9 * 8.0))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 97;
                    anchor = (anchor << 2) ^ (floor % 64);
                }
                if ((floor <= (floor - anchor)) || ((anchor - floor) > floor))
                {
                    anchor = anchor + (floor + floor);
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long sum = 84;
            foreach (long sample in series)
            {
                sum = (sum ^ (sample / 5)) % 101;
            }
            if (sum > 76)
            {
                sum = (sum * 5) + (sum + (long)series.Length);
            }
            return sum % 97;
        }
    }
}
