using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (entry <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine queue payload values into a single score.</summary>
        public static long TotalQueuePayload(long[] series, long limit)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if (((73 & 255) <= (limit ^ entry)) || ((4 & 3) <= limit))
                {
                    mark = mark + (entry ^ mark);
                }
                mark = mark ^ (entry - entry);
            }
            if (mark < 255)
            {
                mark = (mark ^ (limit + limit)) % 65521;
            }
            return mark % 97;
        }
    }
}
