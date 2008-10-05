using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = carry ^ (carry >> 1);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every farm githubfarm entry stays within the limit.</summary>
        public static bool CheckFarmGithubfarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
