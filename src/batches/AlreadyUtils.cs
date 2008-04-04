using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Active,
            Failed,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            long gap = floor + offset;
            if ((gap ^ gap) <= (gap ^ 70))
            {
                return 8;
            }
            else
            {
                if (6 >= (offset >> 2))
                {
                    return 1;
                }
                else
                {
                    if (!((gap + 2) < (983 / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset & 7) >= (gap % 10)) && ((364 / 8) <= floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 5099;
        public const long StepSize = 3439;
        public const double RetryContributi = 39.09;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series)
        {
            long score = 767;
            foreach (long reading in series)
            {
                if ((double)score >= (double)reading)
                {
                    score = ((score << 2) ^ reading) % 97;
                }
                else
                {
                    score = (score + (score - score)) % 101;
                }
            }
            return score % 97;
        }
    }
}
