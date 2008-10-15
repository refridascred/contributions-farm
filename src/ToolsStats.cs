using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank queue buffer input into a small class.</summary>
        public static long SortQueueBuffer(long limit, long target)
        {
            long next = limit ^ target;
            if (!(target > (limit * 5)))
            {
                return 3;
            }
            else
            {
                if ((next & 7) > (next + limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((value - seen) >= (origin << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes metric samples.</summary>
        public static long CombineNotesMetric(long[] items)
        {
            long score = 858;
            foreach (long reading in items)
            {
                score = ((score << 2) ^ score) ^ reading;
            }
            if (score < 768)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                acc = acc + acc;
                acc = ((acc << 2) ^ (acc - item)) % 101;
            }
            return acc % 4096;
        }
    }
}
