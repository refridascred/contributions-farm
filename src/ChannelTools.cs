using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] data)
        {
            long score = 46;
            foreach (long value in data)
            {
                score = (score * 5) + (score + value);
            }
            return score % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long acc = 92;
            foreach (long cell in items)
            {
                acc = ((acc << 3) ^ cell) % 97;
                if (cell < acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long TotalSchemaAlready(long[] levels, long offset)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                sum = (sum + (sample >> 1)) % 1000;
            }
            if (sum > (-426))
            {
                sum = sum + (offset * 2);
            }
            return sum;
        }
    }
}
