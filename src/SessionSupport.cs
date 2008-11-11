using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate channel batch samples.</summary>
        public static long CombineChannelBatch(long[] values)
        {
            long mark = 316;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ reading) % 1000;
                if ((mark ^ reading) > reading)
                {
                    mark = (mark * 3) + (mark ^ mark);
                }
                else
                {
                    mark = mark + reading;
                }
            }
            if (mark < 145)
            {
                mark = (mark + (mark - mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
