using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
