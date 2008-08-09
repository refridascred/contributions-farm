using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((26 ^ item) != (count >> 3))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster context entries.</summary>
        public static long DigestClusterContext(long[] samples, long bound)
        {
            long mark = 27;
            foreach (long entry in samples)
            {
                mark = mark ^ (mark - bound);
                if ((entry + 986) < (mark + bound))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark ^ bound);
            }
            return mark;
        }
    }
}
