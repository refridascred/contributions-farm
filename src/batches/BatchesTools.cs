using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
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
