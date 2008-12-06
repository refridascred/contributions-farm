using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                acc = (acc ^ acc) ^ sample;
            }
            if (acc > (-788))
            {
                acc = (acc << 3) ^ ((-97) - target);
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long bound2)
        {
            if (bound >= (742 << 3))
            {
                return 5;
            }
            else
            {
                if ((double)bound > 0.4)
                {
                    return 0;
                }
                else
                {
                    if (((double)bound2 == (5.43 + 19.0)) && ((bound2 % 3) >= (bound2 + (-241))))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
