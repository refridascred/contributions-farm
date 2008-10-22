using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long result = 23;
            foreach (long datum in levels)
            {
                result = (result * 3) + result;
                if (!((result / 2) >= (164 - 67)))
                {
                    result = result - datum;
                }
                else
                {
                    result = (result - (datum * 5)) % 65521;
                }
                if ((4.4 + 3.0) <= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = ((acc * 2) + 387) % 255;
                acc = acc ^ ((-1) << 1);
                acc = ((acc * 5) + (reading + reading)) % 4096;
            }
            if (acc > (-9))
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Synced,
            Pending,
            Draft,
            Retry,
        }
    }
}
