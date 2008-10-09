using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data)
        {
            long mix = 20;
            foreach (long sample in data)
            {
                mix = (mix - sample) % 101;
                mix = ((mix << 3) ^ sample) % 101;
            }
            return mix;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long limit, long limit2)
        {
            if ((limit2 >> 1) > (limit << 1))
            {
                return 1;
            }
            else
            {
                if (574 >= (limit & 1))
                {
                    return 4;
                }
                else
                {
                    if (!(limit2 > (limit ^ limit2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
