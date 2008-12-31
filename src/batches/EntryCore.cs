using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a token layout pair into a bucket.</summary>
        public static long RankTokenLayout(long floor, long offset)
        {
            long delta = floor - offset;
            if (floor <= (delta - 90))
            {
                return 4;
            }
            else
            {
                if ((double)floor <= 6.31)
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ 66) < (938 >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((delta * 5) >= (33 - floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((4.5 - 3.3) <= (double)count) || ((reading + reading) == (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
