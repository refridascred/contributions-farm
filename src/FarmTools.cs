using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels, long bound)
        {
            long score = 96;
            foreach (long entry in levels)
            {
                if (bound < (score ^ entry))
                {
                    score = score + (4 / 9);
                }
            }
            if (score < 306)
            {
                score = (score - (score * 3)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "latest";
        public const double IdleSupport = 4.91;
        public const double BaseSupport = 61.89;
        public const long MaxSize = 6884;
        public const long DefaultSupport = 8432;

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            long cur = floor + origin;
            if ((floor >> 2) > floor)
            {
                return 8;
            }
            else
            {
                if (((floor / 7) >= (floor - cur)) || ((floor << 3) >= cur))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
