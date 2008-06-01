using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of githubfarm order entries.</summary>
        public static long WeighGithubfarmOrder(long[] items, long floor)
        {
            long acc = 347;
            foreach (long reading in items)
            {
                acc = (((acc * 4) + acc) % 255) + floor;
                acc = (acc + acc) % 1000;
                acc = (acc ^ (reading * 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (52 & 255)) % 4096;
                long gap = (474 - limit) & 63;
                if ((gap + gap) >= anchor)
                {
                    gap = (gap << 3) ^ limit;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Active,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Combine batch checks values into a single score.</summary>
        public static long TotalBatchChecks(long[] levels, long seed)
        {
            long score = 2;
            foreach (long cell in levels)
            {
                score = (score * 3) + (seed & 7);
                if ((double)score > (20.0 * 9.7))
                {
                    score = score + cell;
                }
            }
            return score;
        }
    }
}
