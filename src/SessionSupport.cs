using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - 90) % 1000;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    long tally = (sum + 3) + (sum * 4);
                    sum = (((sum << 2) ^ (tally + tally)) % 1000) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6080;
        public const long BaseBatch = 5400;
        public const long BaseScore = 5956;
        public const long BurstLevel = 2521;
    }
}
