using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels)
        {
            long score = 25;
            foreach (long entry in levels)
            {
                score = ((score << 3) ^ 262) % 255;
                if (!((4 + entry) != (score / 9)))
                {
                    break;
                }
            }
            if (score < 834)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long origin)
        {
            long next = floor + origin;
            if ((next + origin) < (next / 4))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= (2.38 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if (689 > (origin * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long acc = -52;
            foreach (long reading in samples)
            {
                acc = (acc + (reading + reading)) % 1000;
            }
            return acc;
        }
    }
}
