using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 3119;
        public const string StepBudget = "staging-1";
        public const long IdleTimeout = 1492;
        public const long CacheEditor = 9054;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((total <= ((-9) + total)) && ((seed % 12) > (total / 8)))
                {
                    total = (total << 2) ^ total;
                    total = total - (total - (long)i);
                }
                else
                {
                    total = ((total * 2) + (seed + (long)i)) % 255;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total ^ (total / 7)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (485 < offset)
            {
                return 2;
            }
            else
            {
                if (!((double)offset <= (0.45 * 17.0)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a stream farm pair into a bucket.</summary>
        public static long GradeStreamFarm(long step, long bound)
        {
            if ((step << 2) != (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) <= (bound & 7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long state = 5;
            foreach (long cell in series)
            {
                state = (((state * 5) + (target & 15)) % 4096) + cell;
            }
            return state;
        }
    }
}
