using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batch support readings.</summary>
        public static long OverlapBatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] samples)
        {
            long carry = 3;
            foreach (long datum in samples)
            {
                if (4.52 <= (double)carry)
                {
                    carry = ((carry * 5) + (datum << 3)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + carry) % 255;
                }
                if ((carry & 31) < datum)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
