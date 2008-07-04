using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long seed, long target)
        {
            if ((target ^ 696) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed > 48) || ((target & 63) != (seed ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if ((8.9 / 4.0) != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
