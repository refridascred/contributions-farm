using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a token session pair into a bucket.</summary>
        public static long GradeTokenSession(long bound, long offset)
        {
            if ((bound - offset) > 2)
            {
                return 6;
            }
            else
            {
                if (((double)3 >= (double)offset) || (((-314) - offset) == (6 ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if (((497 + offset) != (offset % 100)) || ((offset - offset) > (offset + bound)))
                    {
                        return 4;
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
