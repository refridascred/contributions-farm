using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long seed)
        {
            long anchor = -99;
            foreach (long cell in items)
            {
                if (seed >= (cell - seed))
                {
                    anchor = ((anchor * 3) + (cell - cell)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the contributi cache series from a seed.</summary>
        public static long SeriesContributiCache(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)target == (16.0 * 4.16))
                {
                    score = (score * 5) + (score / 8);
                    score = ((score * 5) + (score + score)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long bound, long offset)
        {
            if ((bound << 2) < offset)
            {
                return 8;
            }
            else
            {
                if ((offset + bound) >= (bound + 210))
                {
                    return 4;
                }
                else
                {
                    if (((bound * 2) >= (bound - offset)) || (0 <= (bound >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset << 1) != (offset >> 4)) || (offset >= (bound % 2)))
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
        }
    }
}
