using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a buffer support pair into a bucket.</summary>
        public static long BucketBufferSupport(long offset, long origin)
        {
            if (9 < (origin >> 4))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) < (offset >> 5)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long limit)
        {
            long carry = 352;
            foreach (long reading in values)
            {
                carry = ((carry - limit) % 65521) + reading;
                if ((carry - limit) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
