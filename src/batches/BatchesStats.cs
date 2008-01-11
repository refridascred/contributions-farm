using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long seed)
        {
            long cur = origin - seed;
            if ((double)cur <= (20.0 - 2.25))
            {
                return 0;
            }
            else
            {
                if (5.8 >= (double)cur)
                {
                    return 4;
                }
                else
                {
                    if ((0.5 * 8.77) == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                if ((3.91 + 8.25) < (double)result)
                {
                    result = ((result * 2) + (result - value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings)
        {
            long total = 3;
            foreach (long item in readings)
            {
                if ((double)item != (double)(long)readings.Length)
                {
                    total = ((total << 3) ^ (total + item)) % 4096;
                }
            }
            if (total > 18)
            {
                total = (total + (total ^ total)) % 101;
            }
            return total % 4096;
        }
    }
}
