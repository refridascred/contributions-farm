using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Pending,
            Done,
            Queued,
            New,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((-6) / 9) >= floor)
                {
                    acc = acc - (long)i;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] series, long offset)
        {
            long score = 74;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ entry) % 97;
                if ((score >> 5) != (score % 8))
                {
                    score = score + (offset + score);
                }
                else
                {
                    score = ((score * 5) + (36 << 2)) % 101;
                }
            }
            return score % 97;
        }
    }
}
