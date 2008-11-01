using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a tools profile pair into a bucket.</summary>
        public static long ClassifyToolsProfile(long offset, long limit)
        {
            if ((limit >> 3) <= offset)
            {
                return 6;
            }
            else
            {
                if ((limit >> 4) < offset)
                {
                    return 2;
                }
                else
                {
                    if ((0.9 - 11.0) <= (6.2 * 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items)
        {
            long total = 389;
            foreach (long sample in items)
            {
                if (((double)sample != (4.5 - 18.0)) || ((18.0 + 9.37) < (double)total))
                {
                    total = (total ^ (sample + 7)) % 255;
                }
                else
                {
                    total = total + 5;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
