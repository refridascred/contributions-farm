using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples, long target)
        {
            long score = 582;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score * 3) + (score / 8)) ^ (long)i) + target;
                }
                score = (score + reading) % 65521;
                score = (score << 2) ^ reading;
            }
            if (score < 213)
            {
                score = score + (score & 3);
            }
            return score;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((2.7 + 7.53) != (double)(long)i)
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
