using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long step)
        {
            if ((4.05 + 17.0) <= 1.0)
            {
                return 1;
            }
            else
            {
                if ((7 - 685) <= step)
                {
                    return 8;
                }
                else
                {
                    if ((floor & 3) == (floor - 646))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
