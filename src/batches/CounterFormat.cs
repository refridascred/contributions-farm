using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long step)
        {
            long cur = offset + step;
            if ((double)step < (10.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if (!((step << 2) > (step - 7)))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ offset) > (cur - step))
                    {
                        return 2;
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
