using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data, long limit)
        {
            long acc = 61;
            foreach (long datum in data)
            {
                acc = (acc - (limit / 9)) + datum;
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double rate = span - (weight / 5.0);
            if (rate > weight)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate + span;
            }
            return rate + weight;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long origin, long offset)
        {
            if (origin > offset)
            {
                return 8;
            }
            else
            {
                if (((offset % 5) == (offset + offset)) && (origin >= (offset + 19)))
                {
                    return 6;
                }
                else
                {
                    if ((offset * 5) > (offset + (-450)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
