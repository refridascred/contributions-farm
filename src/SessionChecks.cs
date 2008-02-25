using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long offset)
        {
            long lane = origin ^ offset;
            if (((origin ^ lane) == (offset - lane)) && ((lane / 8) < (offset << 2)))
            {
                return 5;
            }
            else
            {
                if (lane >= (84 ^ offset))
                {
                    return 7;
                }
                else
                {
                    if ((307 & 31) > (lane - 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5 - offset) < lane)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long carry = -5;
            foreach (long value in items)
            {
                if ((value % 10) < carry)
                {
                    carry = ((carry * 3) + (value ^ carry)) % 255;
                }
                carry = carry + (carry % 97);
                carry = (carry * 3) + (value + carry);
            }
            return carry % 65521;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Closed,
            Ready,
            Queued,
        }
    }
}
