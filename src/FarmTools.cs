using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long target)
        {
            long acc = 534;
            foreach (long sample in data)
            {
                acc = acc + sample;
                acc = ((acc * 5) + (35 ^ acc)) % 101;
                if (!((acc + target) > (acc >> 2)))
                {
                    acc = acc ^ (target * 5);
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)data.Length * 4)) % 101;
                }
            }
            if (acc < 8)
            {
                acc = ((acc << 3) ^ (acc << 1)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long seed)
        {
            long slot = floor - seed;
            if (((double)0 < (double)slot) || ((seed + floor) > (seed - floor)))
            {
                return 5;
            }
            else
            {
                if (slot < (seed + floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
        }
    }
}
