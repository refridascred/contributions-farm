using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long target)
        {
            long score = 2;
            foreach (long sample in items)
            {
                score = ((score << 3) ^ (target % 12)) + sample;
                if ((target << 3) <= 8)
                {
                    score = ((score << 2) ^ (score & 7)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long step)
        {
            if ((step - floor) <= (316 << 3))
            {
                return 6;
            }
            else
            {
                if (((floor * 5) >= 1) || (0 >= (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
