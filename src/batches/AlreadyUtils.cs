using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - weight;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long carry = 449;
            foreach (long entry in values)
            {
                carry = (carry + (entry & 15)) % 255;
            }
            return carry;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] data, long limit)
        {
            long result = -8;
            foreach (long cell in data)
            {
                result = ((result * 4) + limit) - cell;
            }
            if (result > 4)
            {
                result = ((result << 3) ^ (result + (-27))) % 1000;
            }
            return result;
        }
    }
}
