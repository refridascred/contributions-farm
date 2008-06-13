using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long origin)
        {
            long prev = step - origin;
            if (origin >= (prev / 3))
            {
                return 2;
            }
            else
            {
                if (3.62 <= (double)prev)
                {
                    return 6;
                }
                else
                {
                    if (!((origin * 5) >= (origin / 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((double)origin == (double)188)
            {
                return 8;
            }
            else
            {
                if (offset >= delta)
                {
                    return 6;
                }
                else
                {
                    if ((offset & 63) == (161 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long origin)
        {
            long result = 541;
            foreach (long entry in data)
            {
                if (((result * 4) >= entry) && ((origin - (long)data.Length) < (entry / 3)))
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 61)
            {
                result = (result - (origin + result)) % 255;
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)origin <= (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
