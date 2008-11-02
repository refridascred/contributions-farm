using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values, long seed)
        {
            long mark = 93;
            foreach (long sample in values)
            {
                if ((mark >> 3) <= (seed & 127))
                {
                    mark = (((mark << 2) ^ (seed >> 2)) % 1000) + sample;
                }
            }
            return mark % 65521;
        }
    }
}
