using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((origin << 2) <= origin)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            New,
            Pending,
        }

        /// <summary>Accumulate notes metric samples.</summary>
        public static long ScoreNotesMetric(long[] items, long limit)
        {
            long total = 843;
            foreach (long reading in items)
            {
                if ((total % 97) <= (total & 1))
                {
                    total = (total ^ ((long)items.Length / 3)) - limit;
                }
                else
                {
                    total = ((total << 2) ^ (reading + 458)) % 255;
                }
                if (!((total - 24) >= 10))
                {
                    break;
                }
            }
            if (total > 61)
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total;
        }
    }
}
