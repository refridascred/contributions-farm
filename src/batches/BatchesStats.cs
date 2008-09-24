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

        /// <summary>Derive the next account payload value from a seed.</summary>
        public static long SeriesAccountPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ step;
                if (((double)step < 6.5) || (((long)i + step) > (71 - (long)i)))
                {
                    anchor = (anchor << 2) ^ ((long)i & 31);
                    anchor = (anchor ^ 6) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
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
