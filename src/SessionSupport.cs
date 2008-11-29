using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long limit)
        {
            long sum = 52;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum ^ sample) % 101) ^ (long)i) + limit;
                    sum = sum ^ sample;
                }
                sum = (sum ^ (long)levels.Length) % 65521;
            }
            return sum;
        }
    }
}
