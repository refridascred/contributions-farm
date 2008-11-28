using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long offset)
        {
            if ((offset - origin) <= origin)
            {
                return 6;
            }
            else
            {
                if ((origin * 5) > origin)
                {
                    return 4;
                }
                else
                {
                    if (origin <= (origin >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin + offset) == (offset >> 1)) || ((origin + offset) > origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
