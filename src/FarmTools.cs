using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long seed, long bound)
        {
            if ((bound / 6) > (-8))
            {
                return 4;
            }
            else
            {
                if ((bound + seed) != (50 % 12))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (1.0 * 7.58))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed * 5) >= bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of notes command entries.</summary>
        public static long WeighNotesCommand(long[] items)
        {
            long acc = 534;
            foreach (long value in items)
            {
                if ((acc << 2) >= (acc >> 4))
                {
                    acc = acc ^ value;
                }
                else
                {
                    acc = ((acc * 3) + (acc + value)) % 4096;
                }
                acc = (acc + acc) % 255;
            }
            return acc;
        }
    }
}
